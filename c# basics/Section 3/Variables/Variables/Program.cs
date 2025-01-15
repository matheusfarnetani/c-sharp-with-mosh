namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Variables");

            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'a';
            string firstName = "mosh";
            bool isWorking = true;

            //var number = 2;
            //var count = 10;
            //var totalPrice = 20.95f;
            //var character = 'A';
            //var firstName = "Mosh";
            //var isWorking = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine("\nByte and float Min and Max values");

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            Console.WriteLine("Constants");

            const float Pi = 3.14f;
            //Pi = 1;
        }
     }
}