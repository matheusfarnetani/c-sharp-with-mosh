namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = ReadNumbers("Please, enter a few numbers separated by a hyphen '-'");
            if (IsConsecutive(numbers))
                Console.WriteLine("Consecutive");
            else
                Console.WriteLine("Not Consectuive");
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

        static bool IsConsecutive(int[] numbers)
        {
            if (numbers.Length < 2)
                return false;

            // Determine the step (difference between first two numbers)
            int step = numbers[1] - numbers[0];

            // Check if the step is either +1 (ascending) or -1 (descending)
            if (step != 1 && step != -1)
                return false;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] - numbers[i - 1] != step)
                    return false;
            }

            return true;
        }
    }
}