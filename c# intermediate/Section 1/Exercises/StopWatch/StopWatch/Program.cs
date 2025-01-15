using System.Diagnostics;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();
            stopWatch.StartWatch();

            Thread.Sleep(2000); // Wait 2 seconds
            stopWatch.Stop();
            Thread.Sleep(1500); // Wait 1.5 seconds
            stopWatch.Stop();
            Thread.Sleep(1000); // Wait 1 seconds
            stopWatch.Stop();
            Thread.Sleep(500); // Wait 0.5 seconds
            stopWatch.Stop();

            // Display all stops
            stopWatch.DisplayStops();

            // Get the exact recorded time at the 4th stop
            var timeAtFourStop = stopWatch.GetTimeAtStop(3);
            Console.WriteLine($"Time at 4th stop: {timeAtFourStop}");

            // Get the time between the 2nd and 4th stops
            var timeBetweenSecondAndFourth = stopWatch.GetTimeBetweenStops(1, 3);
            Console.WriteLine($"Time between 2nd and 4th stops: {timeBetweenSecondAndFourth}");
        }
    }
}