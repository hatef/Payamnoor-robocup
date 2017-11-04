using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hadaf
{
    class Config
    {
        private static int delay;

        public static int Delay
        {
            get { return Config.delay; }
            set { Config.delay = value; }
        }
        private static string robotName;

        public static string RobotName
        {
            get { return Config.robotName; }
            set { Config.robotName = value; }
        }
        private static int circleDegree;

        public static int CircleDegree
        {
            get { return Config.circleDegree; }
            set { Config.circleDegree = value; }
        }


        private static string host;

        public static string Host
        {
            get { return Config.host; }
            set { Config.host = value; }
        }
        private static int port;

        public static int Port
        {
            get { return Config.port; }
            set { Config.port = value; }
        }
        private static string teamName;

        public static string TeamName
        {
            get { return Config.teamName; }
            set { Config.teamName = value; }
        }
        private static string hostIP;

        public static string HostIP
        {
            get { return Config.hostIP; }
            set { Config.hostIP = value; }
        }
        private static string logFileName;

        public static string LogFileName
        {
            get { return Config.logFileName; }
            set { Config.logFileName = value; }
        }
        private static int gameTime;

        public static int GameTime
        {
            get { return Config.gameTime; }
            set { Config.gameTime = value; }
        }
       
    }
}
