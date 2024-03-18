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
    public partial class RapKrojcza : Form
    {
        public RapKrojcza()
        {
            InitializeComponent();
        }

        private void sbExportExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog ())
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                    WidokListy.ExportToXls(sfd.FileName + ".xls");
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
                var pobrania = new XPCollection<Model.WZ>(sesja, Filtr).ToList();
                var zwroty = new XPCollection<Model.PZ>(sesja, Filtr).ToList();

                var raport = new List<PozycjaRap>();
                foreach(var pobranie in pobrania)
                {
                    var poz = new PozycjaRap();
                    poz.Data = pobranie.Data;
                    poz.Uzytkownik = pobranie.Uzytkownik.Nazwa;
                    poz.NazwaTkaniny = pobranie.Bela.Material.Nazwa;
                    poz.Ilosc = pobranie.Ilosc;
                    poz.Operacja = "pobranie tkaniny";

                    raport.Add(poz);
                }

                foreach(var zwrot in zwroty)
                {
                    var asoc = sesja.FindObject<Model.AsocPzWz>(CriteriaOperator.Parse("PZ.Id = ?", zwrot.Id));

                    var poz = new PozycjaRap();
                    poz.Data = zwrot.Data;
                    poz.Uzytkownik = zwrot.Uzytkownik.Nazwa;
                    poz.NazwaTkaniny = asoc.WZ.Bela.Material.Nazwa;
                    poz.Ilosc = zwrot.ZwrotMaterial;
                    poz.IloscUszkodzone = zwrot.UszkodzonyMaterial;
                    poz.Operacja = "zwrot tkaniny";

                    raport.Add(poz);

                    foreach (var wykroj in zwrot.ProduktWykrojs)
                    {
                        poz = new PozycjaRap();
                        poz.Data = wykroj.PZ.Data;
                        poz.Uzytkownik = wykroj.PZ.Uzytkownik.Nazwa;
                        poz.NazwaTkaniny = asoc.WZ.Bela.Material.Nazwa;
                        poz.NazwaWykroju = wykroj.Wykroj.Nazwa;
                        poz.Ilosc = wykroj.Ilosc;
                        poz.IloscUszkodzone = wykroj.IloscUszkodzone;
                        poz.Operacja = "przygotowane wykroje";

                        raport.Add(poz);
                    }
                }

                Lista.DataSource = raport;
            }
        }
    }

    class PozycjaRap
    {
        public DateTime Data { get; set; }
        public string Uzytkownik { get; set; }
        public string NazwaTkaniny { get; set; }
        public string NazwaWykroju { get; set; }
        public decimal Ilosc { get; set; }
        public decimal IloscUszkodzone { get; set; }
        public string Operacja { get; set; }
    }
}
