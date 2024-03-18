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

namespace Magazyn.Kartoteki
{
    public partial class Materialy : DevExpress.XtraEditors.XtraForm
    {
        public Materialy()
        {
            InitializeComponent();
        }

        public bool Wybor { get; set; }

        private void Materialy_Load(object sender, EventArgs e)
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
            using (MaterialyEdit okno = new Kartoteki.MaterialyEdit())
            {
                okno.Modyfikacja = false;
                okno.Sesja = new DevExpress.Xpo.UnitOfWork();
                okno.dodawany = new Model.Material(okno.Sesja);
                if (okno.ShowDialog() == DialogResult.OK)
                    Przycisk_Odswiez_ItemClick(null, null);
            }
        }

        private void Przycisk_Edytuj_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (WidokListy.FocusedRowHandle < 0)
                return;

            Model.Material selected = WidokListy.GetRow(WidokListy.FocusedRowHandle) as Model.Material;
            if (selected == null)
                return;

            using (MaterialyEdit okno = new Kartoteki.MaterialyEdit())
            {
                okno.Modyfikacja = true;
                okno.Sesja = new DevExpress.Xpo.UnitOfWork();
                okno.dodawany = okno.Sesja.GetObjectByKey<Model.Material>(selected.Id);
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
                Model.Material mat = Session.DefaultSession.GetObjectByKey<Model.Material>(id);
                if (mat == null)
                    return;

                object o = hi.HitTest.ToString() + hi.RowHandle.ToString();
                string text = "<b>" + mat.Nazwa + "</b>";


                info = new ToolTipControlInfo(o, text);

                if (mat.MaterialZdjecies.FirstOrDefault(p => p.Miniatura) != null)
                {
                    try
                    {
                        Image xZdjTmp = Image.FromFile(Magazyn.Properties.Settings.Default.FolderZdjeciaLokalny + "\\" + mat.MaterialZdjecies.FirstOrDefault(p => p.Miniatura).Nazwa);
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