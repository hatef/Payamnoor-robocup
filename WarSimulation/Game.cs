using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Hadaf
{
    class Game
    {
        public static void Start()
        {
            Decision decision = new Decision();
            Explore explore = new Explore();
           Thread Decide = new Thread(new ThreadStart(decision.Make));
            Thread ExploreIt = new Thread(new ThreadStart(explore.Discover));
            int time=0;

            while (time == 0 || time >= 14999)
            {
                if (Server.ConvertedData != null)
                {
                    string it = Server.ConvertedData.Replace("(", "").Replace(")", "");
                    string[] split = it.Split(' ');
                    int ind = Array.IndexOf(split, "cycle");
                    if (ind > -1)
                    {
                        time = int.Parse(split[ind + 1]);
                    }
                }
            }
               Decide.Start();
                ExploreIt.Start();
           
        }
    }
}
