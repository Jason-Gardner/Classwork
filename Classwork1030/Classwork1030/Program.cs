using System;
using System.Text.RegularExpressions;

namespace Classwork1030
{
    class AssessmentOneReview
    {
        public static void Main(string[] args)
        {
            // Take user input
            Console.Write("Hello, please enter your name: ");
            string input = Console.ReadLine();

            // Call our new name validator method
            bool validName = validateMe(input);
            bool newValid = validateMe(input, @"[a-zA-Z]+");

            // Output result of validation
            Console.WriteLine(validName);

            // Output result of overloaded method
            Console.WriteLine($"Overloaded method result: {newValid}.");

        }
        /// <summary>
        /// Returns a bool based on whether a string is actually a string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool validateMe(string input)
        {
            return Regex.IsMatch(input, @"[a-zA-Z]+"); // Use @symbol - string literal, take it as it is
        }

        public static bool validateMe(string input, string pattern)
        {
            return Regex.IsMatch(input, pattern);
        }
    }
}
