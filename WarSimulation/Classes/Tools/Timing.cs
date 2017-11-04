using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
namespace Hadaf
{
    class Timing
    {
        public static void Delay(int mSecs)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (stopwatch.ElapsedMilliseconds < mSecs)
            {
                continue;
            }
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0}ms", stopwatch.ElapsedMilliseconds);
        }
        private static int cycle;

        public static int Cycle
        {
            get { return Timing.cycle; }
            set { Timing.cycle = value; }
        }
    }
}
