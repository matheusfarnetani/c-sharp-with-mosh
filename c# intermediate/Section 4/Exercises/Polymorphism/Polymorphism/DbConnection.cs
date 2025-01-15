namespace Polymorphism
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set;}
        public TimeSpan Timeout { get; private set; }

        protected DbConnection(string connStr, TimeSpan timeout) 
        {
            if (string.IsNullOrWhiteSpace(connStr))
                throw new ArgumentException("Connection string cannot be null or empty.", nameof(connStr));
            if (timeout <= TimeSpan.Zero)
                throw new ArgumentException("timeout must be greater than zero.", nameof(timeout));

            this.ConnectionString = connStr;
            this.Timeout = timeout;
        }

        public abstract void Open();
        public abstract void Close();

        protected void TryConnect(Func<bool> connectAction)
        {
            var startTime = DateTime.Now;

            while ((DateTime.Now - startTime) < this.Timeout)
            {
                if (connectAction())
                {
                    Console.WriteLine("Connection established.");
                    return;
                }

                Console.WriteLine("Retrying connection...");
                System.Threading.Thread.Sleep(1000); // 1 sec
            }

            throw new TimeoutException("Failed to establish connection withing the specified timeout");
        }
    }
}