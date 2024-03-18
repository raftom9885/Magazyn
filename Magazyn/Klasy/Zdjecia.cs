using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn.Klasy
{
    public static class Zdjecia
    {
        /// <summary>
        /// Funkcja pozwalająca na konwersję zdjęcia na stream i zapisanie go we wskazanej lokalizacji
        /// </summary>
        /// <param name="aImage">zdjęcie</param>
        /// <param name="aFilename">nazwa</param>
        /// <param name="aImageFormat">format zdjęcia</param>
        public static void SaveOnNetworkShare(this System.Drawing.Image aImage, string aFilename, System.Drawing.Imaging.ImageFormat aImageFormat)
        {
            using (System.IO.MemoryStream lMemoryStream = new System.IO.MemoryStream())
            {
                aImage.Save(lMemoryStream, aImageFormat);
                using (System.IO.FileStream lFileStream = new System.IO.FileStream(aFilename, System.IO.FileMode.Create))
                {
                    lMemoryStream.Position = 0;
                    lMemoryStream.CopyTo(lFileStream);
                }
            }
        }

        /// <summary>
        /// Obliczanie wzpółczynnika zdjęcia do zmiany jego rozmiaru
        /// </summary>
        /// <param name="xZdj"></param>
        /// <param name="wymiar">max wysokość zdjęcia</param>
        /// <returns></returns>
        public static decimal ObliczWspolczynnikWgWysokosci(Image xZdj, decimal wymiar)
        {
            decimal Wspolczynnik = 0M;

            if (xZdj.Height > wymiar)
                Wspolczynnik = (decimal)xZdj.Height / wymiar;

            return Wspolczynnik;
        }

        /// <summary>
        /// Obliczanie wzpółczynnika zdjęcia do zmiany jego rozmiaru
        /// </summary>
        /// <param name="xZdj"></param>
        /// <param name="wymiar">max szerokość zdjęcia</param>
        /// <returns></returns>
        public static decimal ObliczWspolczynnikWgSzerokosci(Image xZdj, decimal wymiar)
        {
            decimal Wspolczynnik = 0M;

            if (xZdj.Width > wymiar)
                Wspolczynnik = (decimal)xZdj.Width / wymiar;

            return Wspolczynnik;
        }

        /// <summary>
        /// Funkcja zmieniająca rozmiar zdjęcia
        /// </summary>
        /// <param name="imgToResize"></param>
        /// <param name="Wspolczynnik"></param>
        /// <returns></returns>
        public static Image ZmianaRozdzielczosciZdjecia(Image imgToResize, decimal Wspolczynnik)
        {
            if (Wspolczynnik == 0)
                Wspolczynnik = 1;
            return (Image)(new Bitmap(imgToResize, new Size(Convert.ToInt32((decimal)imgToResize.Width / Wspolczynnik), Convert.ToInt32((decimal)imgToResize.Height / Wspolczynnik))));
        }

        public static Image CreateImage(Image[] images, int wysokosc)
        {
            int width = 0;
            int offset = 4;
            foreach (Image img in images)
                width += (img.Width + offset);
            width -= offset;
            Image newImage = new Bitmap(width, wysokosc);
            int x = 0;
            using (Graphics g = Graphics.FromImage(newImage))
            {
                foreach (Image current in images)
                {
                    g.DrawImage(current, new Point(x, 0));
                    x += current.Width + offset;
                }
            }
            return newImage;
        }

        /// <summary>
        /// Funkcja tworząca nazwę zdjęcia samochodu
        /// </summary>
        /// <param name="xSam"></param>
        /// <returns></returns>
        public static string UtworzNazweMaterialu(Model.Material material)
        {
            int i = 1;
            while (true)
            {
                var xZdj = material.MaterialZdjecies.FirstOrDefault(p => p.Nazwa == "mat_" + material.Id + "_" + i.ToString() + ".jpg");
                if (xZdj == null)
                    return "mat_" + material.Id + "_" + i.ToString();
                i++;
            }
        }
        

        public class Zdjecie
        {
            public Image xZdj { get; set; }
            public string Sciezka { get; set; }
            public bool Zaznacz { get; set; }
            public bool Allegro { get; set; }
            public bool Miniaturka { get; set; }
            public bool Nowe { get; set; }
            public bool DoUsuniecia { get; set; }
            public bool ZBazy { get; set; }
            public int Id { get; set; }
        }

        /// <summary>
        /// Funkcja przeskalowywująca zdjęcie na konkretną wielkość
        /// </summary>
        /// <param name="imgPhoto"></param>
        /// <param name="Width"></param>
        /// <param name="Height"></param>
        /// <returns></returns>
        public static Image Skaluj(Image imgPhoto, int Width, int Height)
        {
            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            int sourceX = 0;
            int sourceY = 0;
            int destX = 0;
            int destY = 0;

            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)Width / (float)sourceWidth);
            nPercentH = ((float)Height / (float)sourceHeight);
            int destWidth = (int)(sourceWidth * nPercentW);
            int destHeight = (int)(sourceHeight * nPercentH);

            Bitmap bmPhoto = new Bitmap(Width, Height);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
                             imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.InterpolationMode =
                    InterpolationMode.HighQualityBicubic;

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            return bmPhoto;
        }
    }
}

