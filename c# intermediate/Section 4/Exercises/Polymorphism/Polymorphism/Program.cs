namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConn = new SqlConnection("Server=myServer;Database=myDb", TimeSpan.FromSeconds(30));
            var oracleConn = new OracleConnection("Server=oracleServer;Database=oracleDB", TimeSpan.FromSeconds(30));

            try
            {
                var sqlCommand = new DbCommand(sqlConn, "SELECT * FROM Users");
                sqlCommand.Execute();
            }
            catch (TimeoutException ex)
            {
                Console.WriteLine($"SQL Command failed: {ex.Message}");
            }

            try
            {
                var oracleCommand = new DbCommand(oracleConn, "SELECT * FROM Employees");
                oracleCommand.Execute();
            }
            catch (TimeoutException ex)
            {
                Console.WriteLine($"Oracle Command failed: {ex.Message}");
            }
        }
    }
}