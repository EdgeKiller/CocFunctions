using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CocFunctions
{
    public static class Window
    {
        public static Size GetBorderSize(Bitmap screenshot)
        {
            Size result = new Size(0, 0);
            Point point = GetDifference(screenshot, Properties.Resources.face);
            result.Height = point.Y - 19;
            result.Width = point.X - 278;

            result.Height -= 25;
            result.Width -= 3;

            return result;
        }


        private static Point GetDifference(Bitmap sourceImage, Bitmap searchImage)
        {
            LockBitmap lockBitmapSource = new LockBitmap(sourceImage);
            LockBitmap lockBitmapSearch = new LockBitmap(searchImage);
            lockBitmapSource.LockBits();
            lockBitmapSearch.LockBits();
            double diff = 0;
            for (int x = 279; x <= 309; x++)
            {
                for (int y = 0; y <= 54; y++)
                {
                    diff = 0;
                    for (int x1 = 0; x1 < lockBitmapSearch.Width; x1++)
                    {
                        for (int y1 = 0; y1 < lockBitmapSearch.Height; y1++)
                        {
                            diff += (double)Math.Abs(lockBitmapSource.GetPixel(x + x1, y + y1).R - lockBitmapSearch.GetPixel(x1, y1).R) / 100;
                            diff += (double)Math.Abs(lockBitmapSource.GetPixel(x + x1, y + y1).G - lockBitmapSearch.GetPixel(x1, y1).G) / 100;
                            diff += (double)Math.Abs(lockBitmapSource.GetPixel(x + x1, y + y1).B - lockBitmapSearch.GetPixel(x1, y1).B) / 100;
                        }
                    }
                    if (diff < 50)
                    {
                        return new Point(x, y);
                        break;
                    }
                    
                }
            }
            lockBitmapSource.UnlockBits();
            lockBitmapSearch.UnlockBits();
            return new Point(-1, -1);
        }
    }
}
