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

namespace Magazyn.Towar
{
    public partial class BelaEdit : DevExpress.XtraEditors.XtraForm
    {
        public BelaEdit()
        {
            InitializeComponent();
        }

        public Model.Bela dodawany { get; set; }
        public bool Modyfikacja { get; set; }
        public UnitOfWork Sesja = new UnitOfWork();

        private void BelaEdit_Load(object sender, EventArgs e)
        {
            if (Modyfikacja)
            {
                teKodKreskowy.Text = dodawany.KodKreskowy;
                caSzerokosc.Value = dodawany.Szerokosc;
                caDlugosc.Value = dodawany.Dlugosc;
                cmbMaterial.EditValue = dodawany.Material.Id;
                chUkonczona.Checked = dodawany.Ukonczona;
            }
        }
        
        public bool Zapisz()
        {
            if(string.IsNullOrWhiteSpace(teKodKreskowy.Text) || caDlugosc.Value <= 0 || caSzerokosc.Value <= 0 || cmbMaterial.EditValue == null)
            {
                XtraMessageBox.Show("Proszę uzupełnić wszystkie dane!");
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

            if (Modyfikacja == false)
                dodawany.DataDodania = DateTime.Now;
            
            dodawany.KodKreskowy = teKodKreskowy.Text;
            dodawany.Szerokosc = caSzerokosc.Value;
            dodawany.Dlugosc = caDlugosc.Value;
            dodawany.Ukonczona = chUkonczona.Checked;
            dodawany.Material = Sesja.GetObjectByKey<Model.Material>(cmbMaterial.EditValue);
            Sesja.CommitChanges();
        }

        private void cmbMaterial_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbMaterial.EditValue != null)
            {
                var mat = Sesja.GetObjectByKey<Model.Material>(cmbMaterial.EditValue);
                if (mat.MaterialZdjecies.FirstOrDefault(p => p.Miniatura == true) != null)
                    pictureEdit1.Image = Image.FromFile(Magazyn.Properties.Settings.Default.FolderZdjeciaLokalny + "\\" + mat.MaterialZdjecies.FirstOrDefault(p => p.Miniatura).Nazwa);
            }
            else
                pictureEdit1.Image = null;
        }
    }
}