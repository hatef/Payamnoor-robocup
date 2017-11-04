using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
namespace Hadaf
{
    class Explore
    {
        Position p1 = OwnRobots.CurrentRobot, p2 = OppRobots.CurrentRobot;
        double slope, Dist;
        double currentDegToOpp;
        public void Discover()
        {
            currentDegToOpp = Mathematics.getSlope(p1, p2);
            double curr=Mathematics.Degree(OwnRobots.CurrentRobot);
            //double Blockdist = Mathematics.Distance(p1, Objects.Block);
            slope = Mathematics.DegreeToOpp(OwnRobots.CurrentRobot, OppRobots.CurrentRobot);
            ExploreCommander.GoForward();
           // ExploreCommander.Turn(slope, Command.Forward);
            ExploreCommander.Turn(curr + 45, Command.Forward);
            Thread.Sleep(400);
            while (true)
            {
               
                Dist = Mathematics.Distance(OwnRobots.CurrentRobot, OppRobots.CurrentRobot);
                    p1 = OwnRobots.CurrentRobot;
                    p2 = OppRobots.CurrentRobot;

                    slope = Mathematics.DegreeToOpp(OwnRobots.CurrentRobot, OppRobots.CurrentRobot);
                    if (Consts.LastCommand != Command.Forward)
                    {
                        ExploreCommander.GoForward();
                        Consts.LastCommand = Command.Forward;

                    }

                    ExploreCommander.Turn(slope, Command.Forward);
                        Follow();
            }
        }
        public void Follow()
        {
            if (Dist < 400)
            {
                if (Consts.LastCommand != Command.Backward)
                {
                    ExploreCommander.GoBackward();
                    Consts.LastCommand = Command.Backward;
                }
                Thread.Sleep(200);
            }
            if (Mathematics.IsEqual(slope, Mathematics.Degree(OwnRobots.CurrentRobot), 4))
                {
                    if (Consts.LastCommand != Command.Stop)
                    {
                        ExploreCommander.Stop();
                        //ExploreCommander.GoForward();
                        Consts.LastCommand = Command.Stop;
                       
                    }
                 }
             if (!Mathematics.IsEqual(slope, Mathematics.Degree(OwnRobots.CurrentRobot), 4))
                {
                    ExploreCommander.Turn(slope,Command.Stop);
                }
        
             if (Dist < 600 && !Mathematics.IsEqual(slope, Mathematics.Degree(OwnRobots.CurrentRobot), 4))
            {
                ExploreCommander.Turn(slope, Command.Stop);
            }
            //else if (Mathematics.IsEqual(slope, Mathematics.Degree(OwnRobots.CurrentRobot), 4) && Dist < 700)
            //{
            //    if (Consts.LastCommand != Command.Stop)
            //    {
            //        ExploreCommander.Stop();
            //        Consts.LastCommand = Command.Stop;
            //        Console.WriteLine("deg==curr && dist<700");
            //    }
            //}
              
            
        }

    }
}
