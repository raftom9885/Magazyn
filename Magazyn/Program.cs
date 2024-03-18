using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazyn
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Klasy.Globalne.CzcionkaDomyslna = DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont;
            Klasy.DotykowyUI.Ustaw();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OknoGlowne());
        }
    }
}
