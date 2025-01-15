namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //for
            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //foreach
            //for version
            var name = "John Smith";

            //Console.WriteLine("\nForeach\nFor Version");
            //for (var i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //foreach version
            Console.WriteLine("\nForeach Version");
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            //foreach with numbers
            Console.WriteLine("\nForeach with numbers");
            var numbers = new int[] { 1, 2, 3, 4 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //while
            Console.WriteLine("\nWhile");

            //for version
            //for (var j = 1; j <= 10; j++)
            //{
            //    if (j % 2 == 0)
            //        Console.WriteLine(j);
            //}

            var j = 0;
            while (j <= 10)
            {
                if (j % 2 == 0)
                    Console.WriteLine(j);
                j++;
            }

            while (true)
            {
                Console.Write("Type your name: Option 1");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    break;
                Console.WriteLine("@Echo: " + input);
            }

            while (true)
            {
                Console.Write("Type your name: Option 2");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                break;
            }

        }
    }
}