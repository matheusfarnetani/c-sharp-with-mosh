using System.Reflection.PortableExecutable;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            var userInput = Console.ReadLine();
            Console.WriteLine(ReverseString(userInput));
        }

        static string ReverseString(string str)
        {
            return new string(str.Reverse().ToArray());
            //var length = str.Length;
            //var buffer = new char[length];
            //for (int i = 0; i < length; i++)
            //{
            //    buffer[length - i - 1] = str[i];
            //}
            //return new string(buffer);
        }
    }
}