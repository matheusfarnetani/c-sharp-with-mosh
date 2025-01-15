namespace StopWatch
{
    public class StopWatch
    {
        // Properties
        public DateTime Start { get; private set; }
        private readonly List<TimeSpan> _stops;

        // Constructor (with or without Overload)
        public StopWatch()
        {
            _stops = new List<TimeSpan>();
        }

        // Methods

        // Start the stopwatch
        public void StartWatch()
        {
            Start = DateTime.Now;
            _stops.Clear();
            Console.WriteLine($"Stopwatch started at {Start}");
        }

        // Record a stop
        public void Stop()
        {
            if (Start == default)
                Console.WriteLine("Error: Stopwatch hasn't started yet.");

            var elapsed = DateTime.Now - Start;
            _stops.Add(elapsed);

            Console.WriteLine($"Stop recorded. Elapsed {elapsed}");
        }

        // Get the time between start and specific stop
        public TimeSpan GetTimeAtStop(int stopIndex)
        {
            if (stopIndex < 0 || stopIndex >= _stops.Count)
                throw new IndexOutOfRangeException("Invalid stop index");

            return _stops[stopIndex];
        }

        // Get the time between any two stops
        public TimeSpan GetTimeBetweenStops(int startStopIndex, int endStopIndex)
        {
            if (startStopIndex < 0 || startStopIndex >= _stops.Count)
                throw new IndexOutOfRangeException("Invalid start stop index.");
            if (endStopIndex < 0 || endStopIndex >= _stops.Count)
                throw new IndexOutOfRangeException("Invalid end stop index");
            if (startStopIndex >= endStopIndex)
                throw new ArgumentException("Start stop index must be less than end stop index");

            return _stops[endStopIndex] - _stops[startStopIndex];
        }

        // Display all stops
        public void DisplayStops()
        {
            if (_stops.Count == 0)
            {
                Console.WriteLine("No stops recorded.");
                return;
            }

            Console.WriteLine("Stops recorded:");
            for (int i = 0; i < _stops.Count; i++)
            {
                Console.WriteLine($"Stop {i + 1}: {_stops[i]}");
            }
        }
    }
}