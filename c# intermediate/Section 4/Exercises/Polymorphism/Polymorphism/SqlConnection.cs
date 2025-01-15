namespace Polymorphism
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connStr, TimeSpan timeout) 
            : base(connStr, timeout) 
        {

        }

        public override void Open()
        {
            Console.WriteLine("Attempting to open SQL connection...");
            TryConnect(() =>
            {
                // Simulate 50%/50%
                var sucess = new Random().Next(0, 10) == 1;
                return sucess;
            });
        }

        public override void Close()
        {
            Console.WriteLine("Closing SQL connection...");
        }
    }
}