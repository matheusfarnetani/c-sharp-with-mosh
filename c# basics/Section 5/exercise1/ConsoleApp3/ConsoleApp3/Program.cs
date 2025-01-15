namespace exercise3
{
    public enum ImageOrientation
    {
        Portrait,
        Landscape,
    }
    class Program
    {
        static void Main(string[] args)
        {
            int width = ReadNumbers("What is the width of the image?");
            int height = ReadNumbers("What is the height of the image?");

            int result = width - height;
            result = (result > 0) ? 1 : 0;

            var orientation = (ImageOrientation)result;

            Console.WriteLine("This is a {0} image", orientation);

        }

        static int ReadNumbers(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                var input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                    return number;
                else
                    Console.WriteLine("Invalid Input. Please enter a integer.");
            }
        }
    }
}