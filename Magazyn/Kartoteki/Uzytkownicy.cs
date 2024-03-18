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

namespace Magazyn.Kartoteki
{
    public partial class Uzytkownicy : DevExpress.XtraEditors.XtraForm
    {
        public Uzytkownicy()
        {
            InitializeComponent();
        }

        public bool Wybor { get; set; }

        private void Uzytkownicy_Load(object sender, EventArgs e)
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
            using (UzytkownicyEdit okno = new Kartoteki.UzytkownicyEdit())
            {
                okno.Modyfikacja = false;
                okno.Sesja = new DevExpress.Xpo.UnitOfWork();
                okno.dodawany = new Model.Uzytkownicy(okno.Sesja);
                if (okno.ShowDialog() == DialogResult.OK)
                    Przycisk_Odswiez_ItemClick(null, null);
            }
        }

        private void Przycisk_Edytuj_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (WidokListy.FocusedRowHandle < 0)
                return;

            Model.Uzytkownicy selected = WidokListy.GetRow(WidokListy.FocusedRowHandle) as Model.Uzytkownicy;
            if (selected == null)
                return;

            using (UzytkownicyEdit okno = new Kartoteki.UzytkownicyEdit())
            {
                okno.Modyfikacja = true;
                okno.Sesja = new DevExpress.Xpo.UnitOfWork();
                okno.dodawany = okno.Sesja.GetObjectByKey<Model.Uzytkownicy>(selected.Id);
                if (okno.ShowDialog() == DialogResult.OK)
                    Przycisk_Odswiez_ItemClick(null, null);
            }
        }
    }
}