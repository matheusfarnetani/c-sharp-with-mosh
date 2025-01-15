namespace Polymorphism
{
    public class DbCommand
    {
        public DbConnection Connection { get; private set; }
        public string Instruction {  get; private set; }

        public DbCommand(DbConnection conn, string instruction)
        {
            if (string.IsNullOrWhiteSpace(instruction))
                throw new ArgumentException("Instruction cannot be null or empty.", nameof(instruction));
            this.Connection = conn;
            this.Instruction = instruction;
        }

        public void Execute()
        {
            Connection.Open();
            Console.WriteLine($"Executing: {Instruction}");
            Connection.Close();
        }
    }
}