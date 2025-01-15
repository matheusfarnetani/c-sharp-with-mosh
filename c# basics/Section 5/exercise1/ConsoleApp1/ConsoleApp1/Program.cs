namespace exercise1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 to 10");
            var userInput = Console.ReadLine();

            //parse to int
            try
            {
                int userNumber = Convert.ToInt32((string)userInput);
                Console.WriteLine("Valid");

            }
            catch (Exception)
            {

                Console.WriteLine("Invalid");
            }
        }
    }
}