using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelPhotoProcessing
{
    internal class Filters
    {
        public static Bitmap ApplyGrayscale(Bitmap img)
        {
            Bitmap newImg = new Bitmap(img.Width, img.Height);

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color c = img.GetPixel(i, j);
                    int avg = (c.R + c.G + c.B) / 3;
                    newImg.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
                }
            }
            return newImg;            
        }

        public static Bitmap ApplyMirror(Bitmap img)
        {
            Bitmap newImg = new Bitmap(img.Width, img.Height);

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    newImg.SetPixel(i, j, img.GetPixel(img.Width - i - 1, j));
                }
            }
            return newImg;
        }

        public static Bitmap ApplyThreshold(Bitmap img)
        {
            Bitmap newImg = new Bitmap(img.Width, img.Height);

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color c = img.GetPixel(i, j);
                    int avg = (c.R + c.G + c.B) / 3;
                    if (avg > 128)
                    {
                        newImg.SetPixel(i, j, Color.White);
                    }
                    else
                    {
                        newImg.SetPixel(i, j, Color.Black);
                    }
                }
            }
            return newImg;
        }

        public static Bitmap ApplyNegative(Bitmap img)
        {
            Bitmap newImg = new Bitmap(img.Width, img.Height);

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color c = img.GetPixel(i, j);
                    newImg.SetPixel(i, j, Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
                }
            }
            return newImg;
        }
    }
}
