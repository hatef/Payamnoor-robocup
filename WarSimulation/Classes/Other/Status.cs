using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hadaf
{
    class Status
    {
        private static int grenade;
        private static int fire;

        public static int Fire
        {
            get { return Status.fire; }
            set { Status.fire = value; }
        }
        public static int Grenade
        {
            get { return Status.grenade; }
            set { Status.grenade = value; }
        }

    }
}
