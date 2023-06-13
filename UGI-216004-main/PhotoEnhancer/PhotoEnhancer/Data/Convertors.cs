using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    public static class Convertors
    {
        public static Photo BitmapToPhoto(Bitmap bmp)
        {
            var photo = new Photo(bmp.Width, bmp.Height);

            for(var x = 0; x < bmp.Width; x++)
                for(var y = 0; y < bmp.Height; y++)
                {
                    var p = bmp.GetPixel(x, y);
                    photo[x, y] = new Pixel(p.R / 255.0, p.G / 255.0, p.B / 255.0);
                }

            return photo;
        }

        public static Bitmap PhotoToBitmap(Photo photo)
        {
            var bmp = new Bitmap(photo.Width, photo.Height);

            for (var x = 0; x < photo.Width; x++)
                for (var y = 0; y < photo.Height; y++)
                    bmp.SetPixel(x, y, 
                        Color.FromArgb(
                        (int)Math.Round(photo[x, y].R * 255),
                        (int)Math.Round(photo[x, y].G * 255),
                        (int)Math.Round(photo[x, y].B * 255)
                        ));
            return bmp;
        }

        public static Pixel HSLToRGB(double h, double s, double l)
        {
            double q;
            if (l < 0.5)
                q = l * (1 + s);
            else
                q = l + s - (l * s);
            double p = 2 * l - q;
            h = h / 360;
            double tr = h + 1.0 / 3.0;
            double tg = h;
            double tb = h - 1.0 / 3.0;
            double g = (GetChannels(tg, q, p));
            double b = (GetChannels(tb, q, p));
            double r = (GetChannels(tr, q, p));
            return new Pixel(r, g, b);
        }

        private static double GetChannels(double h, double s, double l)
        {
            if (h < 0)
                h += 1;
            if (h > 1)
                h -= 1;

            if (h < 1.0 / 6.0)
                return l + ((s - l) * 6 * h);
            if ((h >= 1.0 / 6.0) && (h < 0.5))
                return s;
            if ((h >= 0.5) && (h < 2.0 / 3.0))
                return l + ((s - l) * (2.0 / 3.0 - h) * 6);
            else
                return l;
        }
    }
}
