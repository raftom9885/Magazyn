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
using DevExpress.XtraEditors.Controls;
using DevExpress.Data.Filtering;
using System.IO;

namespace Magazyn.Kartoteki
{
    public partial class UzytkownicyEdit : DevExpress.XtraEditors.XtraForm
    {
        public UzytkownicyEdit()
        {
            InitializeComponent();
        }

        public Model.Uzytkownicy dodawany { get; set; }
        public bool Modyfikacja { get; set; }
        public UnitOfWork Sesja = new UnitOfWork();

        private void UzytkownicyEdit_Load(object sender, EventArgs e)
        {
            if (Modyfikacja)
            {
                teKodKreskowy.Text = dodawany.KodKreskowy;
                teLogin.Text = dodawany.Nazwa;
                chNieaktywny.Checked = dodawany.Nieaktywny;
            }
        }
        
        public bool Zapisz()
        {
            if(string.IsNullOrWhiteSpace(teLogin.Text) || string.IsNullOrWhiteSpace(teKodKreskowy.Text))
            {
                XtraMessageBox.Show("Proszę uzupełnić login i kod kreskowy!");
                return true;
            }

            return false;
        }

        private void Przycisk_Zapisz_Click(object sender, EventArgs e)
        {
            if (Zapisz())
            {
                DialogResult = DialogResult.None;
                return;
            }

            dodawany.KodKreskowy = teKodKreskowy.Text;
            dodawany.Nazwa = teLogin.Text;
            dodawany.Nieaktywny = chNieaktywny.Checked;
            Sesja.CommitChanges();
        }
    }
}