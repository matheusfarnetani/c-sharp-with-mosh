namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = ReadNumbers("Enter a number: ", "ok");
            int sum = CalculateSum(numbers);

            int length = numbers.Count;
            Console.WriteLine("Numbers:");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i]);
                if (i != length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine("\nTotal sum is: {0}", sum);
        }
        static List<int> ReadNumbers(string prompt, string key)
        {
            var numbers = new List<int>();
            while (true)
            {
                Console.WriteLine(prompt);
                var input = Console.ReadLine();
                if (input == key)
                    return numbers;
                if (int.TryParse(input, out var number))
                    numbers.Add(number);
                else
                    Console.WriteLine("Invalid Input. Please enter a integer.");
            }
        }
        //static int ReadNumber(string prompt)
        //{
        //    while (true)
        //    {
        //        Console.WriteLine(prompt);
        //        var input = Console.ReadLine();

        //        if (int.TryParse(input, out var number))
        //            return number;
        //        Console.WriteLine("Invalid Input. Please enter a integer.");
        //    }
        //}
        static int CalculateSum(List<int> numbers)
        {
            return numbers.Sum();
        }
    }
}