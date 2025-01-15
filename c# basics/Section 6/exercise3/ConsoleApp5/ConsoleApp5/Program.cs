namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = ReadNumbers("Please supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10)");
            Console.WriteLine("The 3 smallest numbers are {0}, {1}, {2}", numbers[0], numbers[1], numbers[2]);
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
                try
                {
                    var numbers = input.Split(',')
                        .Select(n => int.Parse(n.Trim()))
                        .Distinct()
                        .Order()
                        .ToArray();
                    return numbers;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid List.");
                }
            }
        }
    }
}