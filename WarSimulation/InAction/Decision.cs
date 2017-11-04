using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Hadaf
{
    class Decision
    {
      Position p1 = OwnRobots.CurrentRobot, p2 = OppRobots.CurrentRobot;
        double slope;
        public void Make()
        {
            while (true)
            {
                Fire();
            }
        }
        public void Fire()
        {
            p1 = OwnRobots.CurrentRobot;
            p2 = OppRobots.CurrentRobot;
            slope = Mathematics.DegreeToOpp(OwnRobots.CurrentRobot, OppRobots.CurrentRobot);
            double currentDeg = Mathematics.Degree(p1), dist = Mathematics.Distance(OwnRobots.CurrentRobot, OppRobots.CurrentRobot);

            if (Mathematics.IsEqual(currentDeg, slope, 4))
            {

                FireCommander.Fire();
                if (dist > 1000)
                {
                    FireCommander.Shoot();
                }
               Thread.Sleep(100);
            }
           
            
          
        }
    }
}