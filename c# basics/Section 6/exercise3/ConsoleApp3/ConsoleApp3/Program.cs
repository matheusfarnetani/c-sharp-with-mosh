namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = ReadUniqueNumbers(5);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        static int[] ReadUniqueNumbers(int uniqueNumbers)
        {
            Console.WriteLine("This program needs {0} unique numbers to execute.", uniqueNumbers);

            var buffer = new List<int>();
            while (buffer.Count < uniqueNumbers)
            {
                Console.WriteLine("Write the {0}º unique number. Total of {1}:", buffer.Count + 1, uniqueNumbers);
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input cannot be empty. Please try again.");
                    continue;
                }
                else if (int.TryParse(input, out var number))
                {
                    if (buffer.Contains(number))
                        Console.WriteLine("This number has already been entered. Please enter a different number.");
                    else
                        buffer.Add(number);
                }
                else
                    Console.WriteLine("Invalid Input. Please enter a integer");
            }
            return buffer.Order().ToArray();
        }
    }
}