namespace exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SPEEDLIMIT = 60;

            int speed = ReadNumbers("What is the speed?");
            if (speed <= SPEEDLIMIT)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                int diff = speed - SPEEDLIMIT;
                float demerit = diff / 5;
                if (demerit > 12)
                {
                    Console.WriteLine("License Suspended");
                    Environment.Exit(0);
                }
                Console.WriteLine("Your speed is above the speed limit.\nDemerit points: {0}", demerit);
                Environment.Exit(0);
            }
        }

        static int ReadNumbers(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                var input = Console.ReadLine();

                if (int.TryParse(input, out var number))
                    return number;
                else
                {
                    Console.WriteLine("Invalid Input. Please enter a integer");
                }
            }
        }
    }
}