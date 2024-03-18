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

namespace Magazyn.Ustawienia
{
    public partial class UstawieniaBD : DevExpress.XtraEditors.XtraForm
    {
        public UstawieniaBD()
        {
            InitializeComponent();
        }

        private void UstawieniaBD_Load(object sender, EventArgs e)
        {
            teBD.Text = Magazyn.Properties.Settings.Default.SerwerBazaDanych;
            teHaslo.Text = Klasy.Szyfrowanie.DecryptStringAES(Magazyn.Properties.Settings.Default.SerwerHaslo, Klasy.Globalne._CryptSalt);
            teLogin.Text = Magazyn.Properties.Settings.Default.SerwerLogin;
            teNazwaSerwera.Text = Magazyn.Properties.Settings.Default.SerwerSerwer;
            teZdjeciaLokalne.Text = Magazyn.Properties.Settings.Default.FolderZdjeciaLokalny;
        }

        private void Przycisk_Zapisz_Click(object sender, EventArgs e)
        {
            Magazyn.Properties.Settings.Default.SerwerBazaDanych = teBD.Text;
            Magazyn.Properties.Settings.Default.SerwerHaslo = Klasy.Szyfrowanie.EncryptStringAES(teHaslo.Text, Klasy.Globalne._CryptSalt);
            Magazyn.Properties.Settings.Default.SerwerLogin = teLogin.Text;
            Magazyn.Properties.Settings.Default.SerwerSerwer = teNazwaSerwera.Text;
            Magazyn.Properties.Settings.Default.FolderZdjeciaLokalny = teZdjeciaLokalne.Text;
            Magazyn.Properties.Settings.Default.Save();
        }

        private void sbWyborFolderZdjecia_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    teZdjeciaLokalne.Text = fbd.SelectedPath;
                }
            }
        }
    }
}