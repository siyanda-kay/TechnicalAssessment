using System;
using System.Collections.Generic;

namespace TechnicalAssessment
{
    /// <summary>
    /// Do Not Edit!
    /// </summary>
    internal static class Helpers
    {
        internal static void WriteIntro()
        {
            Console.WriteLine("Question 1: Mobii Fastest Works Task");
            Console.WriteLine("Example of Work id:              BE53484F-7CB4-4066-90CE-7E0F1E06A3F8");
            Console.WriteLine("Example of Ordered Id:           ----00001334444566677889ABBCCEEEEFFF");
            Console.WriteLine("Example of all integers summed:  85");
            Console.WriteLine("Level of achievement (Any best time):");
            Console.WriteLine("     Greater than 100ms:  Failed");
            Console.WriteLine("     50ms - 100ms:        Slow");
            Console.WriteLine("     20ms - 50ms:         Average");
            Console.WriteLine("     5ms - 20ms:          Good");
            Console.WriteLine("     1ms - 5ms:           Great");
            Console.WriteLine("     Less Than 1ms:       Magnificent");
            Console.WriteLine("Record: 0.511 ms");
            Console.WriteLine();
            Console.WriteLine("Results:");
        }

        /// <summary>
        /// Do Not Edit!
        /// Create N amount of test data
        /// Should not be included in final timings
        /// </summary>
        /// <param name="workCount">Greater than zero count of items to be created</param>
        /// <returns></returns>
        internal static List<Work> GetData(int workCount = 10_000)
        {
            List<Work> data = new List<Work>();

            for (int i = 0; i < workCount; i++)
                data.Add(new Work());

            return data;
        }

        /// <summary>
        /// Do Not Edit!
        /// Writes a pretty message on 
        /// </summary>
        /// <param name="i"></param>
        /// <param name="elapsedMilli"></param>
        internal static void WriteResult(int i, double elapsedMilli)
        {
            ConsoleColor consoleColor = elapsedMilli switch
            {
                > 100 => ConsoleColor.Red,
                >= 5 => ConsoleColor.DarkGreen,
                >= 1 => ConsoleColor.Green,
                < 1 => ConsoleColor.Yellow,
                _ => ConsoleColor.Gray
            };
            string resultText = elapsedMilli switch
            {
                > 100 => "Failed",
                (> 50) and (< 100) => "Slow",
                (> 20) and (< 50) => "Average",
                (> 5) and (< 20) => "Good",
                (> 1) and (< 5) => "Great",
                < 1 => "Magnificent",
                _ => "No Result"
            };

            Console.ForegroundColor = consoleColor;
            Console.WriteLine($"[Attempt {i}] Elapsed Time: {elapsedMilli} [{resultText}]");
            Console.ResetColor();
        }

    }
}
