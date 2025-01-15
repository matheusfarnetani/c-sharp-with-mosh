using System;

namespace CsharpFundamentals
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's your name? ");
            var name = Console.ReadLine();

            var reversed = ReverseName(name);
            Console.WriteLine("Reversed name: " + reversed);

            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number (or 'Quit' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            Console.WriteLine("Unique numbers:");
            foreach (var number in GetUniqueNumbers(numbers))
                Console.WriteLine(number);
        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            return new string(array);
        }

        public static List<int> GetUniqueNumbers(List<int> numbers)
        {
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }
            return uniques;
        }
    }
}