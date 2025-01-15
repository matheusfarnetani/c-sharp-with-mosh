namespace Polymorphism
{
    public class DbConnectionStringBuilder
    {
        public string ConnectionString { get; private set; }

        public DbConnectionStringBuilder(string connStr)
        {
            if (string.IsNullOrWhiteSpace(connStr))
                throw new ArgumentException("Connection string cannot be null or empty");

            this.ConnectionString = connStr;
        }
    }
}