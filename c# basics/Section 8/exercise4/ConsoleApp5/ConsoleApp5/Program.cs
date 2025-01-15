namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Number of vowels: {CountVowels("Enter a word:")}");
        }

        static int CountVowels(string prompt)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int counter = 0;

            while (true)
            {
                Console.WriteLine(prompt);
                var input = Console.ReadLine()?.Trim().ToLower();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Input cannot be empty. Please try again.");
                    continue;
                }
                
                foreach (char c in input)
                {
                    if (Array.Exists(vowels, vowel => vowel == c))
                        counter++;
                }

                break;
            }

            return counter;
        }
    }
}
