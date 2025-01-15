namespace Polymorphism
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connStr, TimeSpan timeout)
            : base(connStr, timeout)
        {

        }

        public override void Open()
        {
            Console.WriteLine("Attempting to open Oracle connection...");
            TryConnect(() =>
            {
                // Simulate 50%/50%
                var sucess = new Random().Next(0, 10) == 1;
                return sucess;
            });
        }
        public override void Close()
        {
            Console.WriteLine("Closing Oracle connection...");
        }
    }
}