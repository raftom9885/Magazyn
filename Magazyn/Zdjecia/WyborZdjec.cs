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

namespace Magazyn.Zdjecia
{
    public partial class WyborZdjec : DevExpress.XtraEditors.XtraForm
    {
        public WyborZdjec()
        {
            InitializeComponent();
        }

        public List<string> SciezkiZdjec { get; set; }

        private void sbWybierz_Click(object sender, EventArgs e)
        {
            SciezkiZdjec.Clear();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string file in openFileDialog1.FileNames)
                {
                    SciezkiZdjec.Add(file);
                }
            }
        }

        private void WyborZdjec_Load(object sender, EventArgs e)
        {
            SciezkiZdjec = new List<string>();
            openFileDialog1.Filter =
                "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
                "All files (*.*)|*.*";
        }

        private void Przycisk_Anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}