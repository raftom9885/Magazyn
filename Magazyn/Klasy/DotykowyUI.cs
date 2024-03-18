using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn.Klasy
{
    public static class DotykowyUI
    {
        public static void Ustaw ()
        {
            DevExpress.XtraEditors.WindowsFormsSettings.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.True;
            DevExpress.XtraEditors.WindowsFormsSettings.TouchScaleFactor = 2.1F;
            DevExpress.XtraEditors.WindowsFormsSettings.ScrollUIMode = ScrollUIMode.Touch;
            DevExpress.XtraEditors.WindowsFormsSettings.ShowTouchScrollBarOnMouseMove = false;
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = new System.Drawing.Font("Arial", 15);
        }

        public static void Usun()
        {
            DevExpress.XtraEditors.WindowsFormsSettings.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.Default;
            DevExpress.XtraEditors.WindowsFormsSettings.TouchScaleFactor = 1F;
            DevExpress.XtraEditors.WindowsFormsSettings.ScrollUIMode = ScrollUIMode.Default;
            DevExpress.XtraEditors.WindowsFormsSettings.ShowTouchScrollBarOnMouseMove = true;
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = Klasy.Globalne.CzcionkaDomyslna;
        }
    }
}
