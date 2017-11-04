using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
namespace Hadaf
{
    class Server
    {
        private static Logging log = new Logging();
        private static ASCIIEncoding encoder = new ASCIIEncoding();
        private static byte[] data = new byte[1024];
        private static byte[] recievedData;
        private static string convertedData;
        private static bool connected;
        private static int prevCycle;
        public static bool Connected
        {
            get { return Server.connected; }
            set { Server.connected = value; }
        }
        public static string ConvertedData
        {
            get { return Server.convertedData; }
            set { Server.convertedData = value; }
        }
        private static Socket socket;
        private static IPEndPoint end;
        public static Socket Connect()
        {
            try
            {
                Server.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Server.end = new IPEndPoint(IPAddress.Parse(Config.HostIP), Config.Port);
                socket.Connect(Server.end);
                if (socket.Connected)
                    Console.WriteLine("Connected to {0} ({1})",Config.Host,Config.HostIP);
            }
            catch 
            {
                Console.WriteLine("Couldn't connect to {0} on port {1}.\n Press any key to close",Config.Host,Config.Port);
                Console.ReadKey();
            }
            return socket;
        }
     public static void Message(string message)
     {
             Server.data = Server.encoder.GetBytes(message);
             if (Server.socket.Connected)
             {
                 Server.Connected = true;
                 if (Timing.Cycle < Server.prevCycle)
                 {
                     Server.socket.Send(Server.data);
                     Console.WriteLine("Sent Message: {0}", message);
                     log.Log("Hadaf: " + message + "  Cycle: " + Timing.Cycle);
                     Console.WriteLine("Hadaf: " + message + " Cycle: " + Timing.Cycle);
                 }
                 prevCycle = Timing.Cycle;
             }
         
     }
     public static void BeginRecieve()
     {
         if (socket.Connected)
         {
             
             while (true)
             {
                 try
                 {
                     Server.recievedData = new byte[socket.ReceiveBufferSize];
                     socket.Receive(Server.recievedData);
                     Server.convertedData = "";
                     Server.convertedData = ASCIIEncoding.ASCII.GetString(recievedData);
                         if (Server.convertedData != "")
                         {
                           
                                 Parser parser = new Parser(Server.convertedData);
                                 parser.ExtractWords();
                         }
                 }
                 catch
                 {
                     Console.ForegroundColor = ConsoleColor.Red;
                     Console.WriteLine("Disconnected from {0} ({1})",Config.Host,Config.HostIP);
                     Console.ReadKey();
                 }
                 Thread.Sleep(200);
             }
         }
     }

    }
}
