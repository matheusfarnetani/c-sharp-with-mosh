namespace CsharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            //Random numbers
            Console.WriteLine("Random numbers");
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next());
            }

            //Random numbers between 1 and 10
            Console.WriteLine("\nRandom numbers between 1 and 10");
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(1, 10));
            }

            //Random Characters (random password)
            Console.WriteLine("\nRandom characters (random password)");
            Console.WriteLine("ASCI of a: " + (int)'a'); //asci

            const int passwordLength = 10;

            char[] buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));

            var password = new string(buffer);

            Console.WriteLine(password);
        }
    }
}