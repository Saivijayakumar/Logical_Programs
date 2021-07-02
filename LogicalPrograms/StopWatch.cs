using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class StopWatch
    {
        public static void MeasuringTime()
        {
            //We have pre-defined class for stopwatch
            Stopwatch stopwatch = new Stopwatch();

            //stopwatch start
            stopwatch.Start();

            //It will help the code to run a while so that we can get some time 
            Thread.Sleep(900);

            //stopwatch stop
            stopwatch.Stop();

            //timespan is used to store time intervals
            TimeSpan ts = stopwatch.Elapsed;

            //printing using string interpolation
            Console.WriteLine($"Time Elapsed {ts.Hours} hrs : {ts.Minutes} mins : {ts.Seconds} secs : {ts.Milliseconds} ms");
        }
    }
}
