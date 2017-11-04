using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Hadaf
{
    class Initialize
    {
        public static void Init(string[] Args)
        {
            if (Args.Length >=1)
            {
                Config.TeamName = Args[0];
            }
            if (Args.Length >= 2)
            {
                Config.RobotName = Args[1];
            }
            Parser.ExtractConfigParams();
            Server.Connect();
            Thread dataRecieve = new Thread(new ThreadStart(Server.BeginRecieve));
            dataRecieve.Start();
        }
    }
}
