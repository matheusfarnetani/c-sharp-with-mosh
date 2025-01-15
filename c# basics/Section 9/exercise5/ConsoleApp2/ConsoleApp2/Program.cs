using System;
using System.IO;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\mathe.SOUS\OneDrive\Documentos\udemy\c# basics\exercise5\ConsoleApp2\ConsoleApp2\lorem.txt";

            string? longestWord = FindLongestWordInFile(path);
            if (longestWord != null)
            {
                Console.WriteLine($"The longest word is: {longestWord} with {longestWord.Length} letters");
            }
        }

        static string? FindLongestWordInFile(string filepath)
        {
            var symbols = new[] { ' ', '\r', '\n', '\t', '.', ',', '!', '?' };

            try
            {
                if (!File.Exists(filepath))
                {
                    Console.WriteLine("The file was not found. Please check the file path.");
                    return null;
                }

                string content = File.ReadAllText(filepath);
                var words = content.Split(symbols, StringSplitOptions.RemoveEmptyEntries);

                if (words.Length == 0)
                {
                    Console.WriteLine("The file is empty or contains no valid words.");
                    return null;
                }

                string longestWord = "";
                foreach (var word in words)
                {
                    if (word.Length > longestWord.Length)
                    {
                        longestWord = word;
                    }
                }

                return longestWord;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }
    }
}