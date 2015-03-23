using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocFunctions
{
    public class Attack
    {

        public static List<Point> topleft()
        {
            List<Point> points = new List<Point>();
            points.Add(new Point(420,68));
            points.Add(new Point(370, 112));
            points.Add(new Point(320, 148));
            points.Add(new Point(270, 190));
            points.Add(new Point(220, 222));
            points.Add(new Point(170, 260));
            points.Add(new Point(120, 300));
            points.Add(new Point(70, 336));
            return points;
        }

        public static List<Point> topright()
        {
            List<Point> points = new List<Point>();
            points.Add(new Point(445, 68));
            points.Add(new Point(495, 112));
            points.Add(new Point(545, 148));
            points.Add(new Point(595, 190));
            points.Add(new Point(645, 222));
            points.Add(new Point(695, 260));
            points.Add(new Point(745, 300));
            points.Add(new Point(795, 336));
            return points;
        }

        public static List<Point> bottomright()
        {
            List<Point> points = new List<Point>();
            points.Add(new Point(490, 570));
            points.Add(new Point(540, 538));
            points.Add(new Point(590, 500));
            points.Add(new Point(640, 462));
            points.Add(new Point(690, 424));
            points.Add(new Point(740, 384));
            return points;
        }

        public static List<Point> bottomleft()
        {
            List<Point> points = new List<Point>();
            points.Add(new Point(380, 570));
            points.Add(new Point(330, 538));
            points.Add(new Point(280, 500));
            points.Add(new Point(230, 462));
            points.Add(new Point(180, 424));
            points.Add(new Point(130, 384));
            return points;
        }
    }
}
