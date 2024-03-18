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

namespace Magazyn.Krawcowa
{
    public partial class KrawcowaZwrot : XtraForm
    {
        public KrawcowaZwrot()
        {
            InitializeComponent();
        }
        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Tag == "Zamknij") this.Close();
            else if (e.Button.Properties.Tag == "Zapisz") Zapisz();
        }
        
        public void Zapisz()
        {
            if (WidokListy.FocusedRowHandle < 0 || WidokListy.GetSelectedRows().Count() != 1)
            {
                MessageBox.Show("Proszę wybrać dokładnie jeden wiersz");
                return;
            }

            if(caIlosc.Value <= 0 && caIloscUszkodzone.Value <= 0)
            {
                MessageBox.Show("Proszę wpisać ilość");
                return;
            }

            using (UnitOfWork sesja = new UnitOfWork())
            {
                var uzytkownik = sesja.FindObject<Model.Uzytkownicy>(CriteriaOperator.Parse("KodKreskowy = ?", teKodKreskowy.Text));
                if (uzytkownik == null)
                {
                    MessageBox.Show("Użytkownik o danym kodzie kreskowym nie istnieje");
                    return;
                }

                object id = WidokListy.GetRowCellValue(WidokListy.FocusedRowHandle, "Id");
                var stan = sesja.GetObjectByKey<Model.ProduktWykrojStan>(id);

                if(stan.Ilosc < caIlosc.Value + caIloscUszkodzone.Value)
                {
                    MessageBox.Show("Na stanie jest niewystarczająca ilość wykrojów");
                    return;
                }

                Model.ProduktPoduszka poduszka = new Model.ProduktPoduszka(sesja);
                poduszka.Data = DateTime.Now;
                poduszka.Ilosc = Convert.ToInt32(caIlosc.Value);
                poduszka.IloscUszkodzonych = Convert.ToInt32(caIloscUszkodzone.Value);
                poduszka.Material = stan.Material;
                poduszka.Uzytkownik = uzytkownik;
                poduszka.Wykroj = stan.Wykroj;

                stan.Ilosc = stan.Ilosc - (poduszka.Ilosc + poduszka.IloscUszkodzonych);

                sesja.CommitChanges();
            }

            WidokListy.ClearSelection();
            caIlosc.Value = 0;
            caIloscUszkodzone.Value = 0;
            DaneWykroje.Reload();
            WidokListy.RefreshData();
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
                Model.ProduktWykrojStan stan = Session.DefaultSession.GetObjectByKey<Model.ProduktWykrojStan>(id);
                if (stan == null || stan.Material == null)
                    return;

                object o = hi.HitTest.ToString() + hi.RowHandle.ToString();
                string text = "<b>" + stan.Material.Nazwa + "</b>";


                info = new ToolTipControlInfo(o, text);

                if (stan.Material.MaterialZdjecies.FirstOrDefault(p => p.Miniatura) != null)
                {
                    try
                    {
                        Image xZdjTmp = Image.FromFile(Magazyn.Properties.Settings.Default.FolderZdjeciaLokalny + "\\" + stan.Material.MaterialZdjecies.FirstOrDefault(p => p.Miniatura).Nazwa);
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
