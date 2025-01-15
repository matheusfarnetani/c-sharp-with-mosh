using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = ReadNumbers("Please, write a number:");
            foreach (var number in numbers)
                Console.WriteLine(number);
        }

        static int[] ReadNumbers(string prompt)
        {
            var buffer = new List<int>();
            while (true)
            {
                Console.WriteLine(prompt);
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input cannot be empty. Please try again.");
                    continue;
                }
                else if (input == "Quit")
                {
                    return buffer.Distinct().Order().ToArray();
                }
                else if (int.TryParse(input, out var number))
                {
                    buffer.Add(number);
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please enter a integer");
                }
            }
        }
    }
}