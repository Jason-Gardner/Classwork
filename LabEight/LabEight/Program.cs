using System;
using System.Text.RegularExpressions;

namespace LabEight
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Parallel arrays to pull information from
            string[] studentName = new string[] {
                "Brisco",
                "Terry",
                "Bob",
                "Yancy",
                "Zeeel",
                "Amelia",
                "Kyle",
                "Erin",
                "Isabelle",
                "Lily" };

            string[] studentCity = new string[] {
                "Deeetroit",
                "Detroit",
                "Cleveland",
                "Chicago",
                "Detroit",
                "Windsor",
                "Detroit",
                "Detroit",
                "Novi",
                "Okemos" };

            string[] studentFood = new string[] {
                "Pizza",
                "Tacos",
                "Cheese Bread",
                "Iced Tea",
                "Land O' Lakes",
                "Tiramisu",
                "Apples",
                "Ice Cream",
                "Corn",
                "Cheese" };

            // Introduces program, asks user if they want a list printed of all students
            Console.WriteLine("Welcome to the Grand Circus Student Directory!");
            Console.WriteLine("**********************************************");
            Console.WriteLine();
            bool repeat = true;

            Console.WriteLine("Would you like to see the class list?");
            string classChoice = Console.ReadLine().ToLower();

            while (idCheck(classChoice, "(y)|(n)|(yes)|(no)") == false)
            {
                Console.WriteLine("That is not a valid response. Please enter yes or no.");
                classChoice = Console.ReadLine().ToLower();
            }

            if (classChoice.StartsWith("y"))
            {
                Console.WriteLine();
                Console.WriteLine("Fall 2045 C#12.0 Cohort");
                Console.WriteLine("***********************");
                Console.WriteLine();
                for (int index = 0; index < studentName.Length; index++)
                {
                    Console.WriteLine((index + 1) + $". {studentName[index]}");
                }
            }
            Console.WriteLine();

            do
            {
                // Ask for user input of student number
                Console.WriteLine("Enter a student number between 1 - 10:");
                string yourID = Console.ReadLine();
                int studID;
                string infoChoice;
                string learnMore;

                // Makes sure the input is in fact a number
                try
                {
                    studID = int.Parse(yourID);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! Please enter a number between 1 - 10.");
                    continue;
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Invalid input! Please enter a number between 1 - 10.");
                    continue;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Invalid input! Please enter a number between 1 - 10.");
                    continue;
                }

                // Makes sure the input falls within our array
                try
                {
                    Console.WriteLine($"Student number {studID} is {studentName[studID - 1]}.");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("That student does not exist, please enter a number between 1 - 10.");
                    continue;
                }
                Console.WriteLine();

                // Determines what the user wants to know about the student
                do
                {
                    Console.WriteLine($"What would you like to know about {studentName[studID - 1]}? You can say hometown or favorite food.");
                    infoChoice = Console.ReadLine().ToLower();
                    while (idCheck(infoChoice, "(hometown)|(favorite food)") == false)
                    {
                        Console.WriteLine("That is not a valid choice. Please choose between hometown or favorite food.");
                        infoChoice = Console.ReadLine().ToLower();
                    }

                    if (infoChoice == "hometown")
                    {
                        Console.WriteLine($"{studentName[studID - 1]} is from {studentCity[studID - 1]}.");
                    }
                    if (infoChoice == "favorite food")
                    {
                        Console.WriteLine($"{studentName[studID - 1]}'s favorite food is {studentFood[studID - 1]}.");
                    }

                    // Determines whether the user wants more information about the student chosen
                    Console.WriteLine();
                    Console.WriteLine("Would you like to know more? Please enter yes or no.");
                    learnMore = Console.ReadLine().ToLower();

                    while (idCheck(learnMore, "(y)|(n)|(yes)|(no)") == false)
                    {
                        Console.Write("That is not a valid choice. Please choose between yes or no:");
                        learnMore = Console.ReadLine().ToLower();
                    }
                } while (learnMore == "y" | learnMore == "yes");

                // Determine whether the user wants to know about another student or end the program
                Console.WriteLine();
                Console.WriteLine("Would you like to know more about another student? Please enter yes or no.");
                learnMore = Console.ReadLine().ToLower();
                while (idCheck(learnMore, "(y)|(n)|(yes)|(no)") == false)
                {
                    Console.Write("That is not a valid choice. Please choose between yes or no: ");
                    learnMore = Console.ReadLine().ToLower();
                }
                if (learnMore == "n" | learnMore == "no")
                {
                    repeat = false;
                }
                Console.WriteLine();
            } while (repeat == true);

            Console.WriteLine("Thank you for using the Grand Circus Class Directory!");
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^Goodbye!^^^^^^^^^^^^^^^^^^^^^^");
            return;


        }

        public static bool idCheck(string ID, string pattern)
        {
            if (Regex.IsMatch(ID, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
