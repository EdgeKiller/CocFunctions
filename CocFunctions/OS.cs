using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocFunctions
{
    public static class OS
    {

        public static int GetOS()
        {
            int result = 0;
            if (Environment.OSVersion.Version.ToString().StartsWith("6.2"))
            {
                result = 4; //windows 8
            }
            else if (Environment.OSVersion.Version.ToString().StartsWith("6.1"))
            {
                result = 3; //windows 7
            }
            else if (Environment.OSVersion.Version.ToString().StartsWith("6.0"))
            {
                result = 2; //windows vista
            }
            else if (Environment.OSVersion.Version.ToString().StartsWith("5"))
            {
                result = 1; //windows xp (32/64bits) + windows 2000
            }
            return result;
        }

    }
}
