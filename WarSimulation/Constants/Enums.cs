using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hadaf
{
   enum Command
   {
   Forward,
    Backward,
       Fire,
       Grenade,
       TurnLeft,
       TurnRight,
       Turn,
       Stop,
       TurnDegree
   }
    enum Commander{
        Decision,
        Explore
    }
   class Consts
   {
       private static Command lastCommand = new Command();
       private static Commander priority = new Commander();

       internal static Commander Priority
       {
           get { return Consts.priority; }
           set { Consts.priority = value; }
       }
       internal static Command LastCommand
       {
           get { return Consts.lastCommand; }
           set { Consts.lastCommand = value; }
       }
   }
}
