using System.Text;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10);

            Console.WriteLine(builder);

            builder.Replace('-', '+');

            Console.WriteLine(builder);

            builder.Remove(0, 10);

            Console.WriteLine(builder);

            builder.Insert(0, new string('-', 10));

            Console.WriteLine(builder);

            Console.WriteLine("First character: {0}", builder[0]);
        }
    }
}