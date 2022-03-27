using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch cron1 = new Stopwatch();
            Stopwatch cron2 = new Stopwatch();

            cron1.Start();
            Thread.Sleep(1000);
            cron2.Start();
            Thread.Sleep(1000);
            cron1.Stop();
            cron2.Stop();

            TimeSpan ts1 = cron1.Elapsed;
            TimeSpan ts2 = cron2.Elapsed;

            string elapsedTime1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts1.Hours, ts1.Minutes, ts1.Seconds,
            ts1.Milliseconds / 10);
            Console.WriteLine("Cron1 runtime" + elapsedTime1);

            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts2.Hours, ts2.Minutes, ts2.Seconds,
            ts2.Milliseconds / 10);
            Console.WriteLine("Cron2 runtime" + elapsedTime2);
        }
    }
}
