using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazyn.Klasy
{
    public static class PrzechwytywanieBledow
    {
        public static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            try
            {
                string komunikat = "Błąd. Skontaktuj się z administratorem systemu!";

                using (UnitOfWork Sesja = new UnitOfWork())
                {
                    Model.Bledy xBlad = new Model.Bledy(Sesja);
                    xBlad.Data = DateTime.Now;
                    xBlad.Tresc = e.Exception.ToString() + Environment.NewLine + e.Exception.StackTrace;
                    xBlad.WersjaProgramu = Globalne.Wersja.ToString("f0");
                    Sesja.CommitChanges();

                    if (!string.IsNullOrWhiteSpace(xBlad.Tresc))
                    {
                        if (xBlad.Tresc.ToUpper().Contains("BRAK ZAINSTALOWANYCH DRUKAREK"))
                            komunikat = "Brak zainstalowanych drukarek";

                        if (xBlad.Tresc.ToLower().Contains("system.componentmodel.win32exception (0x80004005): w magazynie brak miejsca dla wykonania tego polecenia"))
                            komunikat = "Przepełnienie stosu. Proszę ponownie uruchomić program";

                        if (xBlad.Tresc.ToLower().Contains("nie można zapisać obiektu. został on zmodyfikowany lub skasowany przez inną aplikację"))
                            komunikat = "Nie można zapisać obiektu. Został on zmodyfikowany lub skasowany przez inną aplikację bądź uzytkownika";

                        if (xBlad.Tresc.ToLower().Contains("podczas wykonywania sql") && xBlad.Tresc.ToLower().Contains("narusza klucz obcy") && xBlad.Tresc.ToLower().Contains("modyfikacja lub usunięcie na tabeli"))
                            komunikat = "Dany obiekt jest powiązany z innymi obiektami. Aby go usunąć należy usunąć powiązania";
                    }
                }
                MessageBox.Show(komunikat);
            }
            catch { }
        }

        /// <summary>
        /// Funkcja przechwytująca błędy w aplikacji i zapisująca je w BD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                string komunikat = "Błąd. Skontaktuj się z administratorem systemu!";

                using (UnitOfWork Sesja = new UnitOfWork())
                {
                    Model.Bledy xBlad = new Model.Bledy(Sesja);
                    xBlad.Data = DateTime.Now;
                    xBlad.Tresc = (e.ExceptionObject as Exception).StackTrace;
                    xBlad.WersjaProgramu = Globalne.Wersja.ToString("f0");
                    Sesja.CommitChanges();

                    if (!string.IsNullOrWhiteSpace(xBlad.Tresc))
                    {
                        if (xBlad.Tresc.ToUpper().Contains("BRAK ZAINSTALOWANYCH DRUKAREK"))
                            komunikat = "Brak zainstalowanych drukarek";
                    }
                }

                MessageBox.Show(komunikat);
            }
            catch { }
        }

        public static void ObsluzBlad(Exception ex, string xTresc = "")
        {
            try
            {
                using (UnitOfWork Sesja = new UnitOfWork())
                {
                    Model.Bledy xBlad = new Model.Bledy(Sesja);
                    xBlad.Data = DateTime.Now;
                    xBlad.Tresc = string.IsNullOrEmpty(xTresc) ? ex.StackTrace : xTresc;
                    xBlad.WersjaProgramu = Globalne.Wersja.ToString("f0");
                    Sesja.CommitChanges();
                }
            }
            catch { }
        }
    }
}
