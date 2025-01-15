namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var num = int.Parse("abc");
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion failed.");
            }

            var result = int.TryParse("abc", out int number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed.");
        }

        static void UserParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4 }));
        }

        static void UserPoints()
        {
            try
            {
                var point = new Point(10, 2);
                point.Move(new Point(40, 60));
                Console.WriteLine($"Point is at {point.X}, {point.Y}");

                point.Move(10, 2);
                Console.WriteLine($"Point is at {point.X}, {point.Y}");
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured");
            }
        }
    }
}