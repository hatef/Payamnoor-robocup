using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hadaf
{
    class ExploreCommander
    {
        public static void GoForward()
        {
            Server.Message("( forward )");
        }

        public static void GoBackward()
        {
            Server.Message("( backward )");
        }

        public static void TurnLeft()
        {
            Server.Message("( turnl )");
        }

        public static void TurnRight()
        {
            Server.Message("( turnr )");
        }
        public static void Stop()
        {
            Server.Message("( stop )");
        }

        public static void TurnLeft(double deg)
        {
            double cdegree=Mathematics.Degree(OwnRobots.CurrentRobot);
            if (cdegree > deg)
            {
                if (Consts.LastCommand != Command.TurnLeft)
                {
                    ExploreCommander.TurnLeft();
                    Consts.LastCommand = Command.TurnLeft;
                }
            }
        }
        public static void TurnRight(double deg)
        {
            double cdegree = Mathematics.Degree(OwnRobots.CurrentRobot);
            if (cdegree < deg)
            {
                if (Consts.LastCommand != Command.TurnRight)
                {
                    ExploreCommander.TurnRight();
                    Consts.LastCommand = Command.TurnRight;
                }
               
            }
        }
        public static void Turn(double degree,Command command)
        {
            
            double currentDegree =Mathematics.Degree(OwnRobots.CurrentRobot);
           
                if (degree < currentDegree)
                {
                    while (degree <= currentDegree)
                    {

                        currentDegree =Mathematics.Degree(OwnRobots.CurrentRobot);
                        ExploreCommander.TurnLeft(degree);
                    }
                }
                else
                {
                    while (degree >= currentDegree)
                    {

                        currentDegree =Mathematics.Degree(OwnRobots.CurrentRobot);
                        ExploreCommander.TurnRight(degree);
                    }
                }
            
            ExploreCommander.Stop();
            ExploreCommander.SelectedCommand(command);
            Console.WriteLine(Mathematics.Degree(OwnRobots.CurrentRobot).ToString());
        }
        private static void SelectedCommand(Command cmd)
        {
            switch (cmd)
            {
                case Command.Forward:
                    ExploreCommander.GoForward();
                    break;
                case Command.Backward:
                    ExploreCommander.GoBackward();
                    break;

            }
        }
    }
}
