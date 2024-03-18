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
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace Magazyn.Krojcza
{
    public partial class KrojczaPobranie : XtraForm
    {
        public KrojczaPobranie()
        {
            InitializeComponent();
        }
        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Tag == "Zamknij") this.Close();
            else if (e.Button.Properties.Tag == "Pobierz") Pobranie();
        }

        public void Pobranie()
        {
            if (WidokListy.FocusedRowHandle < 0 || WidokListy.GetSelectedRows().Count() != 1)
            {
                MessageBox.Show("Proszę wybrać dokładnie jedną belę");
                return;
            }

            using (UnitOfWork sesja = new UnitOfWork())
            {
                var uzytkownik = sesja.FindObject<Model.Uzytkownicy>(CriteriaOperator.Parse("KodKreskowy = ?", teKodKreskowy.Text));
                if(uzytkownik == null)
                {
                    MessageBox.Show("Użytkownik o danym kodzie kreskowym nie istnieje");
                    return;
                }

                object id = WidokListy.GetRowCellValue(WidokListy.FocusedRowHandle, "Id");
                var bela = sesja.GetObjectByKey<Model.Bela>(id);

                if(bela.Dlugosc < caIlosc.Value)
                {
                    MessageBox.Show("Nie można pobrać takiej długości z beli. Bela ma długość [m] " + bela.Dlugosc);
                    return;
                }

                var wz = new Model.WZ(sesja);
                wz.Bela = bela;
                wz.Data = DateTime.Now;
                wz.Ilosc = caIlosc.Value;
                wz.Uzytkownik = uzytkownik;
                wz.Bela.Ukonczona = chBelaUkonczona.Checked;

                sesja.CommitChanges();

                this.Close();
            }
        }

        private void Dymek_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            ToolTipControlInfo info = null;
            GridView view = Lista.GetViewAt(e.ControlMousePosition) as GridView;
            if (view == null) return;
            GridHitInfo hi = view.CalcHitInfo(e.ControlMousePosition);
            if (hi.RowHandle < 0)
                return;

            object id = WidokListy.GetRowCellValue(hi.RowHandle, "Id");
            if (id == null)
                return;
            try
            {
                Model.Bela bela = Session.DefaultSession.GetObjectByKey<Model.Bela>(id);
                if (bela == null || bela.Material == null)
                    return;

                object o = hi.HitTest.ToString() + hi.RowHandle.ToString();
                string text = "<b>" + bela.KodKreskowy + "</b>";


                info = new ToolTipControlInfo(o, text);

                if (bela.Material.MaterialZdjecies.FirstOrDefault(p => p.Miniatura) != null)
                {
                    try
                    {
                        Image xZdjTmp = Image.FromFile(Magazyn.Properties.Settings.Default.FolderZdjeciaLokalny + "\\" + bela.Material.MaterialZdjecies.FirstOrDefault(p => p.Miniatura).Nazwa);
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
    }
}
