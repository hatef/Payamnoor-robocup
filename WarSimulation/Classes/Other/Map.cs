using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hadaf
{
    class Map
    {
        private static double x;

        public static double X
        {
            get { return Map.x; }
            set { Map.x = value; }
        }
        private static double y;

        public static double Y
        {
            get { return Map.y; }
            set { Map.y = value; }
        }
    }
}
