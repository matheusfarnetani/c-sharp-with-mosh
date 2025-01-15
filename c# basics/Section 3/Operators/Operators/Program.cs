namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;

            Console.WriteLine(a + b);
            Console.WriteLine(a / b);
            Console.WriteLine((float)a / (float)b);

            //operators precedents

            var x = 1;
            var y = 2;
            var z = 3;

            Console.WriteLine(x + y * z);
            Console.WriteLine((x + y) * z);

            //comparison operators

            Console.WriteLine(x > y);
            Console.WriteLine(x == y);
            Console.WriteLine(x != y);
            Console.WriteLine(!(x != y));
            Console.WriteLine(z > y && z > x);
            Console.WriteLine(z > y && z == x);
            Console.WriteLine(z > y || z == x);
            Console.WriteLine(!(z > y || z == x));
        }
    }
}