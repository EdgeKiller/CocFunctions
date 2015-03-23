using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocFunctions
{
    public class Read
    {
        public static int GetNumberResources(Bitmap sourceImage)
        {
            Dictionary<string, Bitmap> dicoResString = new Dictionary<string, Bitmap>();
            dicoResString.Add("0", Properties.Resources._0);
            dicoResString.Add("1", Properties.Resources._1);
            dicoResString.Add("2", Properties.Resources._2);
            dicoResString.Add("3", Properties.Resources._3);
            dicoResString.Add("4", Properties.Resources._4);
            dicoResString.Add("5", Properties.Resources._5);
            dicoResString.Add("6", Properties.Resources._6);
            dicoResString.Add("7", Properties.Resources._7);
            dicoResString.Add("8", Properties.Resources._8);
            dicoResString.Add("9", Properties.Resources._9);
            string finalNumber = "";
            List<string> allNumber = new List<string>();
            for (int i = 0; i <= 9; i++)
            {
                List<Point> recup = GetDifference(sourceImage, dicoResString[i.ToString()], 100);
                foreach (Point point in recup)
                {
                    allNumber.Add(point.X + ";" + i.ToString());
                }
            }
            allNumber.Sort(CompareNomPersonne);
            foreach(string number in allNumber)
            {
                finalNumber = finalNumber + number.Split(';')[1];
            }
            int returnInt = 0;
            try
            {
                returnInt = Convert.ToInt32(finalNumber);
            }
            catch{ }
            return returnInt;
        }

        public static int GetNumberGain(Bitmap sourceImage)
        {
            Dictionary<string, Bitmap> dicoResString = new Dictionary<string, Bitmap>();
            dicoResString.Add("0", Properties.Resources._0_gain);
            dicoResString.Add("1", Properties.Resources._1_gain);
            dicoResString.Add("2", Properties.Resources._2_gain);
            dicoResString.Add("3", Properties.Resources._3_gain);
            dicoResString.Add("4", Properties.Resources._4_gain);
            dicoResString.Add("5", Properties.Resources._5_gain);
            dicoResString.Add("6", Properties.Resources._6_gain);
            dicoResString.Add("7", Properties.Resources._7_gain);
            dicoResString.Add("8", Properties.Resources._8_gain);
            dicoResString.Add("9", Properties.Resources._9_gain);
            string finalNumber = "";
            List<string> allNumber = new List<string>();
            for (int i = 0; i <= 9; i++)
            {
                List<Point> recup = GetDifference(sourceImage, dicoResString[i.ToString()], 100);
                foreach (Point point in recup)
                {
                    allNumber.Add(point.X + ";" + i.ToString());
                }
            }
            allNumber.Sort(CompareNomPersonne);
            foreach (string number in allNumber)
            {
                finalNumber = finalNumber + number.Split(';')[1];
            }
            int returnInt = 0;
            try
            {
                returnInt = Convert.ToInt32(finalNumber);
            }
            catch { }
            return returnInt;
        }

        private static int CompareNomPersonne(string string1, string string2)
        {
            if (Convert.ToInt32(string1.Split(';')[0]) > Convert.ToInt32(string2.Split(';')[0]))
                return 1;
            return -1;
        }

        private static List<Point> GetDifference(Bitmap sourceImage, Bitmap searchImage, int maxDiff)
        {
            LockBitmap lockBitmapSource = new LockBitmap(sourceImage);
            LockBitmap lockBitmapSearch = new LockBitmap(searchImage);
            lockBitmapSource.LockBits();
            lockBitmapSearch.LockBits();
            double diff = 0;
            List<Point> points = new List<Point>();
            for (int x = 0; x < lockBitmapSource.Width - lockBitmapSearch.Width + 1; x++)
            {
                for (int y = 0; y < lockBitmapSource.Height - lockBitmapSearch.Height + 1; y++)
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
                    if (diff < maxDiff)
                    {
                        points.Add(new Point(x, y));
                        x += 5;
                        break;
                    }
                    
                }
            }
            lockBitmapSource.UnlockBits();
            lockBitmapSearch.UnlockBits();
            return points;
        }
    }
}
