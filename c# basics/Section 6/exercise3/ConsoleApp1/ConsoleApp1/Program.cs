using System.ComponentModel;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = ReadNames("Type a name: (Press enter to execute program).");

            var length = names.Length;
            if (length == 0)
                Console.WriteLine();
            else if (length == 1)
                Console.WriteLine("{0} likes your post", names[0]);
            else if (length == 2)
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            else
                Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], length - 2);
        }
        static string[] ReadNames(string prompt)
        {
            var buffer = new List<string>();
            while (true)
            {
                Console.WriteLine(prompt);
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    break;
                buffer.Add(input);
            }
            return buffer.ToArray();
        }
    }
}