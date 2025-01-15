namespace Polymorphism
{
    public class TimeOut
    {
        public TimeSpan Time { get; private set; }
        public TimeOut(TimeSpan time)
        {
            if (time <= TimeSpan.Zero)
                throw new ArgumentException("Timeout must be greater than zero.", nameof(time));
            this.Time = time;
        }
    }
}