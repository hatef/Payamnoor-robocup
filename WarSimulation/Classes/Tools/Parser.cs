using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Hadaf
{
    class Parser
    {
        private string input;
        public string Input
        {
            get { return input; }
            set { input = value; }
        }
        string[] Splited;
        public Parser(string inp)
        {
            input = inp;
        }
        public void Normalize()
        {
            input = input.Replace("(", "");
            input = input.Replace(")", "");
        }
        public void ExtractWords()
        {
            Normalize();
            Splited = new string[input.Split(' ').Length];
            Splited = input.Split(' ');
            SetParams();
        }
        public void SetParams()
        {
            for (int i = 0; i < Splited.Length-1; i++)
            {
                try
                {
                    switch (Splited[i])
                    {
                        case "self":
                            OwnRobots.CurrentRobot.X = double.Parse(Splited[i + 2]);
                            OwnRobots.CurrentRobot.Z = double.Parse(Splited[i + 3]);
                            OwnRobots.CurrentRobot.Y = double.Parse(Splited[i + 4]);
                            OwnRobots.CurrentRobot.Theta.X = double.Parse(Splited[i + 7]);
                            OwnRobots.CurrentRobot.Theta.Y = double.Parse(Splited[i + 9]);
                            OwnRobots.CurrentRobot.Theta.Z = double.Parse(Splited[i + 8]);
                            OwnRobots.CurrentRobot.Health = int.Parse(Splited[i + 13]);
                            break;
                        case "Opponents":
                            OppRobots.CurrentRobot.X = double.Parse(Splited[i + 3]);
                            OppRobots.CurrentRobot.Z = double.Parse(Splited[i + 4]);
                            OppRobots.CurrentRobot.Y = double.Parse(Splited[i + 5]);
                            OppRobots.CurrentRobot.Theta.X = double.Parse(Splited[i + 8]);
                            OppRobots.CurrentRobot.Theta.Y = double.Parse(Splited[i + 10]);
                            OppRobots.CurrentRobot.Theta.Z = double.Parse(Splited[i + 9]);
                            break;
                        case "fire":
                            Status.Fire = int.Parse(Splited[i + 1]);
                            break;
                        case "graner":
                            Status.Grenade = int.Parse(Splited[i + 1]);
                            break;
                        case "map":
                            Map.X = double.Parse(Splited[i + 2]);
                            Map.Y = double.Parse(Splited[i + 3]);
                            break;
                        case "hear":
                            MessageCommander.HearMessage = Splited[i + 1];
                            break;
                        case "Block":
                            Objects.Block.X = double.Parse(Splited[i + 2]);
                            Objects.Block.Z = double.Parse(Splited[i + 3]);
                            Objects.Block.Y = double.Parse(Splited[i + 4]);
                            break;
                        case "cycle":
                            Timing.Cycle = int.Parse(Splited[i + 1]);
                            break;
                    }
                }
                catch { }
            }
        }
        public static void ExtractConfigParams()
        {
            StreamReader reader = new StreamReader(Path.GetFullPath(".")+"/Configs/Config.ini");
            string line;
            string[] split = new string[2];
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                split = line.Split(':');
                switch (split[0])
                {
                    case "Host Name":
                        Config.Host = split[1].Trim();
                        break;
                    case "Game Time":
                        Config.GameTime =int.Parse(split[1]);
                        break;
                    case "Host IP":
                        Config.HostIP = split[1].Trim();
                        break;
                    case "Port":
                        Config.Port =int.Parse(split[1]);
                        break;
                    case "Team Name":
                        Config.TeamName = split[1].Trim();
                        break;
                    case "Log Path":
                        Config.LogFileName = split[1].Trim();
                        break;
                    case "Delay":
                        Config.Delay = int.Parse(split[1].Trim());
                        break;
                }
            }
        }
    }
}
