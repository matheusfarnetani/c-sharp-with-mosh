using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = ReadTime("Please enter a time (hh, hh:mm, hh:mm:ss");
            Console.WriteLine($"The total time entered is: {time}");
        }

        static TimeSpan ReadTime(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                var input = Console.ReadLine()?.Trim(); // Read and Trim

                if (String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input cannot be empty. Please try again.");
                    continue;
                }

                // Validate format: hh, hh:mm, hh:mm:ss
                var timeComponents = input.Split(':');
                if (timeComponents.Length > 3 || timeComponents.Length < 1)
                {
                    Console.WriteLine("Invalid format. User hh, hh:mm, or hh:mm:ss");
                    continue;
                }

                try
                {
                    // Handle single value as hours
                    if (timeComponents.Length == 1)
                    {
                        if (int.TryParse(timeComponents[0], out var hours) && hours >= 0 && hours <= 23)
                        {
                            return TimeSpan.FromHours(hours);
                        }
                        else
                        {
                            Console.WriteLine("Invalid value for hours. Must be between 0 and 23.");
                            continue;
                        }
                    }

                    // Handle hh:mm or hh:mm:ss
                    for (int i = 0; i < timeComponents.Length; i++)
                    {
                        if (!int.TryParse(timeComponents[i], out var part) || part < 0)
                        {
                            Console.WriteLine($"Invalid value in part {i + 1}. Ensure all values are non-negative integers");
                            throw new FormatException();
                        }

                        // Additional validation for hour, minutes, and seconds ranges
                        if (i == 0 && part > 23) throw new FormatException(); // Hours: 0-23
                        if (i > 0 && part > 59) throw new FormatException(); // Minutes/Seconds: 0-59
                    }

                    return TimeSpan.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid time format. Please use a valid 24-hour format (hh, hh:mm, or hh:mm:ss).");
                }
            }
        }
    }
}