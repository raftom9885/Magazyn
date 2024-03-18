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
using DevExpress.Xpo.DB;

namespace Magazyn
{
    public partial class OknoGlowne : DevExpress.XtraEditors.XtraForm
    {
        public OknoGlowne()
        {
            InitializeComponent();

            try
            {
                string connectionString = MSSqlConnectionProvider.GetConnectionString(Magazyn.Properties.Settings.Default.SerwerSerwer, Magazyn.Properties.Settings.Default.SerwerLogin,
                        Klasy.Szyfrowanie.DecryptStringAES(Magazyn.Properties.Settings.Default.SerwerHaslo, Klasy.Globalne._CryptSalt), Magazyn.Properties.Settings.Default.SerwerBazaDanych);

                IDataLayer dataLayer =
                   XpoDefault.GetDataLayer(connectionString, AutoCreateOption.DatabaseAndSchema);
                XpoDefault.DataLayer = dataLayer;
            }
            catch
            {
                bladPolaczeniaZBD = true;
                return;
            }
        }


        bool bladPolaczeniaZBD = false;

        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

        private void sbUstawieniaBazyDanych_Click(object sender, EventArgs e)
        {
            Klasy.DotykowyUI.Usun();
            using (Ustawienia.UstawieniaBD okno = new Ustawienia.UstawieniaBD())
                okno.ShowDialog();
            Klasy.DotykowyUI.Ustaw();
        }

        private void OknoGlowne_Load(object sender, EventArgs e)
        {
            try
            {
                if (bladPolaczeniaZBD)
                {
                    throw new ArgumentNullException("Błąd połączenia z BD");
                }
            }
            catch (Exception ex)
            {
                Klasy.PrzechwytywanieBledow.ObsluzBlad(ex);
                XtraMessageBox.Show("Błąd połączenia z bazą danych.\r\nProszę sprawdzić ustawienia i uruchomić ponownie program.");
                using (Ustawienia.UstawieniaBD okno = new Ustawienia.UstawieniaBD())
                {
                    okno.ShowDialog();
                    this.Close();
                }
            }
        }

        private void sbSlownikiPracownicy_Click(object sender, EventArgs e)
        {
            Klasy.DotykowyUI.Usun();
            using (Kartoteki.Uzytkownicy okno = new Kartoteki.Uzytkownicy())
                okno.ShowDialog();
            Klasy.DotykowyUI.Ustaw();
        }

        private void sbSlownikiMaterialy_Click(object sender, EventArgs e)
        {
            Klasy.DotykowyUI.Usun();
            using (Kartoteki.Materialy okno = new Kartoteki.Materialy())
                okno.ShowDialog();
            Klasy.DotykowyUI.Ustaw();
        }

        private void sbSlownikiWykroje_Click(object sender, EventArgs e)
        {
            Klasy.DotykowyUI.Usun();
            using (Kartoteki.Wykroje okno = new Kartoteki.Wykroje())
                okno.ShowDialog();
            Klasy.DotykowyUI.Ustaw();
        }

        private void sbSlownikiMagazynTkanin_Click(object sender, EventArgs e)
        {
            Klasy.DotykowyUI.Usun();
            using (Towar.Bela okno = new Towar.Bela())
                okno.ShowDialog();
            Klasy.DotykowyUI.Ustaw();
        }

        private void sbKrojczaPobierz_Click(object sender, EventArgs e)
        {
            using (Krojcza.KrojczaPobranie okno = new Krojcza.KrojczaPobranie())
                okno.ShowDialog();
        }

        private void sbKrojczaZwrot_Click(object sender, EventArgs e)
        {
            using (Krojcza.KrojczaZwrot okno = new Krojcza.KrojczaZwrot())
                okno.ShowDialog();
        }

        private void sbKrawcowaZwrot_Click(object sender, EventArgs e)
        {
            using (Krawcowa.KrawcowaZwrot okno = new Krawcowa.KrawcowaZwrot())
                okno.ShowDialog();
        }

        private void UstawieniaTileBarItem_ItemClick(object sender, TileItemEventArgs e)
        {

        }
    }
}