namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = ReadNumbers("Please enter a series of numbers separated by comma:");
            Console.WriteLine($"The maximum number is: {userInput.Max()}");
        }
        static int[] ReadNumbers(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                var input = Console.ReadLine();

                try
                {
                    var numbers = input.Split(',')
                        .Select(n => int.Parse(n.Trim()))
                        .ToArray();
                    return numbers;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input. Please enter a series of numbers separated by comma.");
                }
            }
        }
    }
}