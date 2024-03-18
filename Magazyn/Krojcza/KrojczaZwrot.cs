using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using DevExpress.XtraBars;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace Magazyn.Krojcza
{
    public partial class KrojczaZwrot : XtraForm
    {
        public KrojczaZwrot()
        {
            InitializeComponent();
        }

        UnitOfWork sesjaTmp = new UnitOfWork();
        BindingList<cProdukt> listaProdukt = new BindingList<cProdukt>();

        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Tag == "Zamknij") this.Close();
            else if (e.Button.Properties.Tag == "Zapisz") Zapisz();
        }

        public void Zapisz()
        {
            using (UnitOfWork sesja = new UnitOfWork())
            {
                var ids = WidokListyWZ.GetSelectedRows();
                int? idMaterial = null;
                var iloscPobrana = 0.0M;

                if (ids.Count() == 0)
                {
                    MessageBox.Show("Należy zaznaczyć minimum jeden materiał");
                    return;
                }

                foreach (var id in ids)
                {
                    var wz = sesja.GetObjectByKey<Model.WZ>(WidokListyWZ.GetRowCellValue(id, "Id"));
                    if (idMaterial != null && idMaterial != wz.Bela.Material.Id)
                    {
                        MessageBox.Show("Nie można zaznaczyć za jadym razem kilku różnych materiałów");
                        return;
                    }
                    idMaterial = wz.Bela.Material.Id;
                    iloscPobrana += wz.Ilosc;
                }

                if (WidokListyWZ.GetSelectedRows().Count() == 0 && caMaterialUszkodzony.Value <= 0 && caMaterialZwrot.Value <= 0)
                {
                    MessageBox.Show("Aby zapisać dokument należy podać ilości produktu/zwrotu.");
                    return;
                }

                if (caMaterialZwrot.Value > 0 && string.IsNullOrWhiteSpace(teZwrotKodKreskowy.Text))
                {
                    MessageBox.Show("Przy zwrocie materiału należy nadać mu nowy kod kreskowy");
                    return;
                }

                if (iloscPobrana < caMaterialZwrot.Value + caMaterialUszkodzony.Value)
                {
                    MessageBox.Show("Ilość zwracana jest większa niż ilość pobrana");
                    return;
                }

                var pz = new Model.PZ(sesja);
                pz.Data = DateTime.Now;
                pz.UszkodzonyMaterial = caMaterialUszkodzony.Value;
                pz.Uwagi = teUwagi.Text;
                pz.Uzytkownik = sesja.FindObject<Model.Uzytkownicy>(CriteriaOperator.Parse("KodKreskowy = ?", teKodKreskowy.Text));
                pz.ZwrotMaterial = caMaterialZwrot.Value;

                var m = sesja.GetObjectByKey<Model.Material>(idMaterial);

                if (pz.ZwrotMaterial > 0)
                {
                    var bela = new Model.Bela(sesja);
                    bela.DataDodania = pz.Data;
                    bela.Dlugosc = pz.ZwrotMaterial;
                    bela.KodKreskowy = teZwrotKodKreskowy.Text;
                    bela.Material = m;
                    bela.Szerokosc = -1;
                }

                foreach (var id in ids)
                {
                    var wz = sesja.GetObjectByKey<Model.WZ>(WidokListyWZ.GetRowCellValue(id, "Id"));
                    var asoc = new Model.AsocPzWz(sesja);
                    asoc.PZ = pz;
                    asoc.WZ = wz;

                    wz.Rozliczono = (bool)WidokListyWZ.GetRowCellValue(id, colRozliczonoCalosc);
                }

                for (int i = 0; i < WidokListyProdukt.DataRowCount; i++)
                {
                    var row = WidokListyProdukt.GetRow(i) as cProdukt;
                    var w = sesja.GetObjectByKey<Model.Wykroj>(row.Wykroj.Id);
                    pz.ProduktWykrojs.Add(
                        new Model.ProduktWykroj(sesja)
                        {
                            Ilosc = row.Ilosc,
                            IloscUszkodzone = row.IloscUszkodzone,
                            Wykroj = w
                        });

                    var stan = sesja.FindObject<Model.ProduktWykrojStan>(CriteriaOperator.Parse("Wykroj.Id = ? and Material.Id", row.Wykroj.Id, m.Id));
                    if (stan == null)
                    {
                        stan = new Model.ProduktWykrojStan(sesja);
                        stan.Wykroj = w;
                        stan.Material = m;
                    }
                    stan.Ilosc += row.Ilosc;
                }

                sesja.CommitChanges();
                this.Close();
            }
        }

        private void teKodKreskowy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3 || e.KeyCode == Keys.Enter)
            {
                var dane = new XPCollection<Model.WZ>(CriteriaOperator.Parse("Uzytkownik.KodKreskowy = ? and Rozliczono = ?", teKodKreskowy.Text, false));
                var daneLista = new List<cWZ>();

                foreach (var d in dane)
                    daneLista.Add(new cWZ() { CzyRozliczono = false, Wz = d, Id = d.Id });

                ListaWZ.DataSource = daneLista;
            }
        }

        private void Dymek_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            ToolTipControlInfo info = null;
            GridView view = ListaWZ.GetViewAt(e.ControlMousePosition) as GridView;
            if (view == null) return;
            GridHitInfo hi = view.CalcHitInfo(e.ControlMousePosition);
            if (hi.RowHandle < 0)
                return;

            object id = WidokListyWZ.GetRowCellValue(hi.RowHandle, "Id");
            if (id == null)
                return;
            try
            {
                Model.WZ wz = Session.DefaultSession.GetObjectByKey<Model.WZ>(id);
                if (wz?.Bela?.Material == null)
                    return;

                object o = hi.HitTest.ToString() + hi.RowHandle.ToString();
                string text = "<b>" + wz.Bela.Material.Nazwa + "</b>";


                info = new ToolTipControlInfo(o, text);

                if (wz.Bela.Material.MaterialZdjecies.FirstOrDefault(p => p.Miniatura) != null)
                {
                    try
                    {
                        Image xZdjTmp = Image.FromFile(Magazyn.Properties.Settings.Default.FolderZdjeciaLokalny + "\\" + wz.Bela.Material.MaterialZdjecies.FirstOrDefault(p => p.Miniatura).Nazwa);
                        info.ToolTipImage = Klasy.Zdjecia.ZmianaRozdzielczosciZdjecia(xZdjTmp, Klasy.Zdjecia.ObliczWspolczynnikWgSzerokosci(xZdjTmp, 300));
                        xZdjTmp = null;
                    }
                    catch { }
                }

                if (info != null)
                    e.Info = info;
            }
            catch { }
        }

        private void KrojczaZwrot_Load(object sender, EventArgs e)
        {
            ListaProdukt.DataSource = listaProdukt;
            repositoryItemSearchLookUpEdit1.DataSource = new XPCollection<Model.Wykroj>(sesjaTmp);
            repositoryItemSearchLookUpEdit1.DisplayMember = "Nazwa";
            //repositoryItemSearchLookUpEdit1.ValueMember = "Id";
        }

        private class cProdukt
        {
            public Model.Wykroj Wykroj { get; set; }
            public int Ilosc { get; set; }
            public int IloscUszkodzone { get; set; }
        }

        private class cWZ
        {
            public int Id { get; set; }
            public Model.WZ Wz { get; set; }
            public bool CzyRozliczono { get; set; }
        }
    }
}
