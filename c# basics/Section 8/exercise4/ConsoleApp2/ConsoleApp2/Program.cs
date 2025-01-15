namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = ReadNumbers("Please, enter a few numbers separated by a hyphen '-'");
            if (HasDuplicates(numbers))
                Console.WriteLine("Has duplicates");
            else
                Console.WriteLine("Does not have duplicate");
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
                    var numbers = input.Split('-')
                        .Select(n => int.Parse(n.Trim()))
                        .ToArray();
                    return numbers;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid List.");
                }
            }
        }

        static bool HasDuplicates(int[] numbers)
        {
            int[] buffer = new int[numbers.Length];
            foreach (int number in numbers)
            {
                if (!buffer.Contains(number))
                    buffer.Append(number);
                else
                    return true;
            }

            return false;
        }
    }
}