namespace Interfaces_and_Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dbMigrator = new DbMigrator(new ConsoleLogger());
            var dbMigrator = new DbMigrator(new FileLogger(Path()));
            dbMigrator.Migrate();
        }

        private static string Path()
        {
            return @"C:\Users\mathe.SOUS\OneDrive\Documentos\udemy\c# intermediate\Section 5\Interfaces and Extensibility\Interfaces and Extensibility\log.txt";
        }
    }
}