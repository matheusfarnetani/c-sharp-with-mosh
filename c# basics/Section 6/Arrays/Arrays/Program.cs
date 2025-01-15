namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Array
            var numbers = new int[6];
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = new Random().Next(1, 10);

            foreach (var number in numbers)
                Console.Write(number + ", ");

            // Length
            Console.WriteLine("\nLenght: {0}", numbers.Length);

            // IndexOf()
            var index = Array.IndexOf(numbers, 4);
            Console.WriteLine("Index of 4 is: {0}", index);

            // Clear()
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("\nEffect of Clear()");
            foreach (var n in numbers)
                Console.Write(n + ", ");
            Console.WriteLine();

            // Copy()
            int[] anotherArray = new int[3];
            Array.Copy(numbers, anotherArray, 3);
            Console.WriteLine("\nEffect of Copy()");
            foreach (var n in anotherArray)
                Console.Write(n + ", ");
            Console.WriteLine();

            // Sort()
            Array.Sort(numbers);
            Console.WriteLine("\nEffect of Sort()");
            foreach (var n in numbers)
                Console.Write(n + ", ");
            Console.WriteLine();

            // Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("\nEffect of Reverse()");
            foreach (var n in numbers)
                Console.Write(n + ", ");
            Console.WriteLine();
        }
    }
}