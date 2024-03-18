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
    public partial class WykrojeEdit : DevExpress.XtraEditors.XtraForm
    {
        public WykrojeEdit()
        {
            InitializeComponent();
        }

        public Model.Wykroj dodawany { get; set; }
        public bool Modyfikacja { get; set; }
        public UnitOfWork Sesja = new UnitOfWork();

        private void WykrojeEdit_Load(object sender, EventArgs e)
        {
            if (Modyfikacja)
            {
                teNazwa.Text = dodawany.Nazwa;
                caSzerokosc.Value = dodawany.Szerokosc;
                caWysokosc.Value = dodawany.Wysokosc;
            }
        }
        
        public bool Zapisz()
        {
            if(string.IsNullOrWhiteSpace(teNazwa.Text))
            {
                XtraMessageBox.Show("Proszę uzupełnić nazwę!");
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
            
            dodawany.Nazwa = teNazwa.Text;
            dodawany.Szerokosc = caSzerokosc.Value;
            dodawany.Wysokosc = caWysokosc.Value;
            Sesja.CommitChanges();
        }
    }
}