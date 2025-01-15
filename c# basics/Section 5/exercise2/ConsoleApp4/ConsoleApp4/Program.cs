namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int FIRSTNUMBER = 1;
            const int SECONDNUMBER = 10;
            const int CHANCES = 4;

            int randomNumber = new Random().Next(FIRSTNUMBER, SECONDNUMBER);
            Console.WriteLine(randomNumber);

            int attempts = 0;
            while (true)
            {
                if (attempts >= CHANCES)
                {
                    Console.WriteLine("You lost!");
                    break;
                }

                Console.WriteLine("Attempt number: {0}", attempts + 1);

                int userInput = ReadNumber("Guess a number:");
                if (userInput == randomNumber)
                {
                    Console.WriteLine("You won!");
                    break;
                }
                else
                {
                    Console.WriteLine("You guessed wrong!");
                }
                attempts++;
            }
        }
        static int ReadNumber(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                var input = Console.ReadLine();
                if (int.TryParse(input, out var number))
                    return number;
                else
                    Console.WriteLine("Invalid Input. Please enter a integer.");
            }
        }
    }
}