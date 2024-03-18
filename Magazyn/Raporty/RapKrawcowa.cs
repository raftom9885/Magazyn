using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazyn.Raporty
{
    public partial class RapKrawcowa: Form
    {
        public RapKrawcowa()
        {
            InitializeComponent();
        }

        private void sbExportExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog ())
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                    WidokListy.ExportToXls(sfd.FileName);
            }
        }

        private void sbGeneruj_Click(object sender, EventArgs e)
        {
            using (UnitOfWork sesja = new UnitOfWork())
            {
                GroupOperator Filtr = new GroupOperator(GroupOperatorType.And);
                Filtr.Operands.Add(CriteriaOperator.Parse("Data >= ? and Data < ?", deDataOd.DateTime, deDataDo.DateTime.AddDays(1)));
                if (searchKrojcza.EditValue != null)
                {
                    Filtr.Operands.Add(CriteriaOperator.Parse("Uzytkownik.Id = ?", (int)searchKrojcza.EditValue));
                }

                var poduszki = new XPCollection<Model.ProduktPoduszka>(sesja, Filtr).ToList();
                Lista.DataSource = poduszki;
            }
        }
    }
}
