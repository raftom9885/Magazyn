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
using System.Drawing.Imaging;

namespace Magazyn.Kartoteki
{
    public partial class MaterialyEdit : DevExpress.XtraEditors.XtraForm
    {
        public MaterialyEdit()
        {
            InitializeComponent();
        }

        public Model.Material dodawany { get; set; }
        public bool Modyfikacja { get; set; }
        public UnitOfWork Sesja = new UnitOfWork();
        List<Klasy.Zdjecia.Zdjecie> ListaZdjec = new List<Klasy.Zdjecia.Zdjecie>();

        private void MaterialyEdit_Load(object sender, EventArgs e)
        {
            if (Modyfikacja)
            {
                teNazwa.Text = dodawany.Nazwa;

                foreach (var xZdjecie in dodawany.MaterialZdjecies)
                {
                    try
                    {
                        Image xTmpZdj = Image.FromFile(Magazyn.Properties.Settings.Default.FolderZdjeciaLokalny + "\\" + xZdjecie.Nazwa);
                        decimal xWspolczynnik = Klasy.Zdjecia.ObliczWspolczynnikWgWysokosci(xTmpZdj, 200M);

                        ListaZdjec.Add(new Klasy.Zdjecia.Zdjecie
                        {
                            Sciezka = Magazyn.Properties.Settings.Default.FolderZdjeciaLokalny + "\\" + xZdjecie.Nazwa,
                            xZdj = Klasy.Zdjecia.ZmianaRozdzielczosciZdjecia(xTmpZdj, xWspolczynnik),
                            DoUsuniecia = false,
                            Nowe = false,
                            Miniaturka = xZdjecie.Miniatura
                        });
                        xTmpZdj.Dispose();
                        GC.Collect();
                    }
                    catch { }
                }

                Lista.DataSource = ListaZdjec.Where(p => p.DoUsuniecia == false);
            }
        }
        
        public bool Zapisz()
        {
            if(string.IsNullOrWhiteSpace(teNazwa.Text))
            {
                XtraMessageBox.Show("Proszę uzupełnić nazwę!");
                return true;
            }
            if (ListaZdjec.Where(p => p.DoUsuniecia == false).Count() > 0 && ListaZdjec.Where(p => p.DoUsuniecia == false && p.Miniaturka).Count() != 1)
            {
                XtraMessageBox.Show("Prosze oznaczyć dokładnie jedno zdjęcie jako miniatura");
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


            Sesja.CommitChanges();

            foreach (var xZdj in ListaZdjec.Where(p => p.Nowe))
            {
                if (xZdj.DoUsuniecia)
                    continue;
                try
                {
                    string NazwaZdjecia = Klasy.Zdjecia.UtworzNazweMaterialu(dodawany) + ".jpg";

                    dodawany.MaterialZdjecies.Add(new Model.MaterialZdjecie(Sesja)
                    {
                        Nazwa = NazwaZdjecia,
                        Material = dodawany,
                        Miniatura = xZdj.Miniaturka
                    });

                    xZdj.Nowe = false;

                    Image zdjMini = Image.FromFile(xZdj.Sciezka);
                    decimal xWspolczynnik = Klasy.Zdjecia.ObliczWspolczynnikWgSzerokosci(zdjMini, Klasy.Globalne.SzerokoscZdjec);
                    Klasy.Zdjecia.SaveOnNetworkShare(Klasy.Zdjecia.ZmianaRozdzielczosciZdjecia(zdjMini, xWspolczynnik), Magazyn.Properties.Settings.Default.FolderZdjeciaLokalny + "\\" + NazwaZdjecia, ImageFormat.Jpeg);
                    zdjMini.Dispose();
                    GC.WaitForFullGCComplete();
                    GC.Collect();
                }
                catch { }
            }

            foreach (var xZdj in ListaZdjec.Where(p => p.Nowe == false && p.DoUsuniecia == false))
            {
                try
                {
                    string nazwaZdjecia = Path.GetFileName(xZdj.Sciezka);
                    var zdj = dodawany.MaterialZdjecies.FirstOrDefault(p => p.Nazwa == nazwaZdjecia);
                    if (zdj != null)
                        zdj.Miniatura = xZdj.Miniaturka;
                }
                catch { }
            }

            foreach (var xZdj in ListaZdjec.Where(p => p.DoUsuniecia))
            {
                try
                {
                    xZdj.DoUsuniecia = false;
                    var xTmpZdj = dodawany.MaterialZdjecies.FirstOrDefault(p => p.Nazwa == Path.GetFileName(xZdj.Sciezka));
                    if (xTmpZdj != null)
                    {
                        Sesja.Delete(xTmpZdj);
                    }
                }
                catch { }
            }

            ListaZdjec.Clear();

            Sesja.CommitChanges();
        }

        private void sbDodaj_Click(object sender, EventArgs e)
        {
            using (Zdjecia.WyborZdjec okno = new Zdjecia.WyborZdjec())
            {
                if (okno.ShowDialog() == DialogResult.OK)
                {
                    foreach (string xSciezka in okno.SciezkiZdjec)
                    {
                        try
                        {
                            Image xTmpZdj = Image.FromFile(xSciezka);
                            decimal xWspolczynnik = Klasy.Zdjecia.ObliczWspolczynnikWgWysokosci(xTmpZdj, 200M);

                            ListaZdjec.Add(new Klasy.Zdjecia.Zdjecie
                            {
                                Sciezka = xSciezka,
                                xZdj = Klasy.Zdjecia.ZmianaRozdzielczosciZdjecia(xTmpZdj, xWspolczynnik),
                                DoUsuniecia = false,
                                Nowe = true,
                            });

                            xTmpZdj.Dispose();
                            GC.Collect();
                        }
                        catch { }
                    }

                    Lista.DataSource = ListaZdjec.Where(p => p.DoUsuniecia == false);
                    WidokListy.RefreshData();
                }
            }
        }

        private void sbUsun_Click(object sender, EventArgs e)
        {
            if (WidokListy.FocusedRowHandle < 0)
                return;

            var xZdj = WidokListy.GetRow(WidokListy.FocusedRowHandle) as Klasy.Zdjecia.Zdjecie;
            xZdj.DoUsuniecia = true;

            Lista.DataSource = ListaZdjec.Where(p => p.DoUsuniecia == false);
            WidokListy.RefreshData();
        }
    }
}