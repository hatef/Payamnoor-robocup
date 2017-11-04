using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;
namespace Hadaf
{
    class FireCommander
    {
        public FireCommander()
        {
        }
        public static void Fire()
        {
            Server.Message("( shoot )");
        }

        public static void Shoot()
        {
            Server.Message("( graner )");
        }
    }
}
