using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Hadaf
{
    class Logging
    {
       private StreamWriter writer = new StreamWriter(Config.LogFileName, true);
        public  void Log(string message)
        {
            
            if (File.Exists(Path.GetFullPath(".")+"\\" + Config.LogFileName ))
            {
                writer.WriteLine(message);
            }
            else
            {
                Console.WriteLine("File does not exist!");
            }
        }
    }
}
