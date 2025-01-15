using System.Numerics;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber = ReadNumber("Please enter a number:");
            Console.WriteLine("{0}! = {1}", userNumber, Factorial(userNumber));
        }
        static int ReadNumber(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                var input = Console.ReadLine();
                if (int.TryParse(input, out var number))
                    return number;
                else
                    Console.WriteLine("Invalid Input. Please enter a integer.");
            }
        }
        static BigInteger Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }
    }
}