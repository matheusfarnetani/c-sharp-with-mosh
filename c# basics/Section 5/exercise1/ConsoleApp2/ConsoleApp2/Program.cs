using System.ComponentModel.Design;

namespace exercise2
{
    partial class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = ReadNumbers("Please enter the first number:");
            int secondNumber = ReadNumbers("Please enter the second number:");
            int[] numbers = new int[2] { firstNumber, secondNumber };
            Console.WriteLine("The maximum is: " + CompareNumbers(numbers));
        }

        static int ReadNumbers(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                var input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please enter a number");
                }
            }
        }

        static int CompareNumbers(int[] numbers)
        {
            return numbers.Max();
        }
    }
}