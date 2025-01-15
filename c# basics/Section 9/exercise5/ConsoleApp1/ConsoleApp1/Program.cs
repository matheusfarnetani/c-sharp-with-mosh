using System;
using System.IO;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\mathe.SOUS\OneDrive\Documentos\udemy\c# basics\exercise5\ConsoleApp1\ConsoleApp1\lorem.txt";

            int wordCount = CountWordsFromFile(path);
            if (wordCount >= 0)
            {
                Console.WriteLine($"The file contains {wordCount} words.");
            }
        }

        static int CountWordsFromFile(string filepath)
        {
            var symbols = new[] { ' ', '\r', '\n', '\t', '.', ',', '!', '?' };

            try
            {
                if (!File.Exists(filepath))
                {
                    Console.WriteLine("The file was not found. Please check the file path.");
                    return -1;
                }

                string content = File.ReadAllText(filepath);
                var words = content.Split(symbols, StringSplitOptions.RemoveEmptyEntries);

                return words.Length;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return -1;
            }
        }
    }
}