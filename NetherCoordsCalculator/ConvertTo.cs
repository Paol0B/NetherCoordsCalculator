using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NetherCoordsCalculator
{
    public static class ConvertTo
    {
        public static double ConvertToNether(double coord)
        {
            coord /= 8;
            return Math.Ceiling(coord);
        }
        public static int ConvertToOverworld(int coord)
        {
            coord *= 8;
            return coord;
        }
    }
}
