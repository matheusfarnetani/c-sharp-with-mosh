namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            var pascal = PascalCase("Enter a few words separated by a space:");
            Console.WriteLine($"`PascalCase: '{pascal}'");
        }

        static string PascalCase(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                var input = Console.ReadLine()?.Trim();

                if (String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input cannot be empty. Please try again.");
                    continue;
                }

                // Converts to lower case and then split into words
                string[] words = input.ToLower().Split(' ');

                for (int i = 0; i < words.Length; i++)
                {
                    if (!string.IsNullOrEmpty(words[i]))
                    {
                        // Convert the first character to uppercase and append the rest of the word
                        words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
                    }
                }

                return string.Join(string.Empty, words);
            }

        }
    }
}