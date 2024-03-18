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
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace Magazyn.Towar
{
    public partial class Bela : DevExpress.XtraEditors.XtraForm
    {
        public Bela()
        {
            InitializeComponent();
        }

        public bool Wybor { get; set; }

        private void Bela_Load(object sender, EventArgs e)
        {
            if (Wybor)
            {
                emptySpace.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlAnuluj.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlWybierz.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
        }

        private void Przycisk_Odswiez_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Dane.Reload();
            WidokListy.RefreshData();
        }

        private void Przycisk_Dodaj_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (BelaEdit okno = new Towar.BelaEdit())
            {
                okno.Modyfikacja = false;
                okno.Sesja = new DevExpress.Xpo.UnitOfWork();
                okno.dodawany = new Model.Bela(okno.Sesja);
                if (okno.ShowDialog() == DialogResult.OK)
                    Przycisk_Odswiez_ItemClick(null, null);
            }
        }

        private void Przycisk_Edytuj_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (WidokListy.FocusedRowHandle < 0)
                return;

            Model.Bela selected = WidokListy.GetRow(WidokListy.FocusedRowHandle) as Model.Bela;
            if (selected == null)
                return;

            using (BelaEdit okno = new Towar.BelaEdit())
            {
                okno.Modyfikacja = true;
                okno.Sesja = new DevExpress.Xpo.UnitOfWork();
                okno.dodawany = okno.Sesja.GetObjectByKey<Model.Bela>(selected.Id);
                if (okno.ShowDialog() == DialogResult.OK)
                    Przycisk_Odswiez_ItemClick(null, null);
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