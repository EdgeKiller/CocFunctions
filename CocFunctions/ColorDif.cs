using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocFunctions
{
    public static class ColorDif
    {

        public static bool isCorrect(Color color, Color color2)
        {
            bool result = true;
            int rDif = Math.Abs(color.R - color2.R);
            int gDif = Math.Abs(color.G - color2.G);
            int bDif = Math.Abs(color.B - color2.B);
            if ((rDif + gDif + bDif) > 30)
                result = false;
            return result;
        }


    }
}
