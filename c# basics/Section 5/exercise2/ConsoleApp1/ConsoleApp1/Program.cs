namespace Exercercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    counter++;
            }
            Console.WriteLine("Number of numbers between 1 and 100 divisible by 3: {0}", counter);
        }
    }
}