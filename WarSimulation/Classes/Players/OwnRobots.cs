using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hadaf
{
    class OwnRobots
    {
        private static Position currentRobot=new Position();
        public static Position CurrentRobot
        {
            get { return currentRobot; }
            set { currentRobot = value; }
        }
        private static Position[] robots = new Position[3];

        public static Position[] Robots
        {
            get { return OwnRobots.robots; }
            set { OwnRobots.robots = value; }
        }
      
    }
    
}
