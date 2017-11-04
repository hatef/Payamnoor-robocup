using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Hadaf
{
    class Program
    {
        static void Main(string[] args)
        {
           /***
            *  Created By Hatef Shamshiri
            *  You are free to use this source as your base code
            * */
          
            Initialize.Init(args);
            Game.Start();
            Console.ReadKey();
        }
    }
}
