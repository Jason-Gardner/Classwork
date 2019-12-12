using System;
using System.Collections.Generic;

namespace LabTwoBonus
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializes the variables we will be using to control proper input and the actual input.

            bool keepTesting = true;
            bool numberCheck = true;
            int yourGrade = 0;
            string choice = "y";
            List<int> gradeList = new List<int>();

            // Asks the user for an input, checks to make sure it is valid.

            Console.WriteLine("Welcome to the Grand Circus Gradebook System!");
            Console.WriteLine("---------------------------------------------");

            do
            {
                Console.WriteLine();
                Console.Write("Please enter your grade between 0 and 100: ");
                string newGrade = Console.ReadLine();
                numberCheck = int.TryParse(newGrade, out yourGrade);
                if (yourGrade >= 0 && yourGrade <= 100 && numberCheck == true)
                {
                    yourGrade = Convert.ToInt32(newGrade);
                    Console.WriteLine(gradeBook(yourGrade));
                    gradeList.Add(yourGrade);
                    Console.WriteLine();
                }
                else
                {
                    do
                    {

                        Console.WriteLine("You did not enter a valid grade.");
                        Console.Write("Please enter a number between 0 - 100: ");
                        newGrade = Console.ReadLine();
                        numberCheck = int.TryParse(newGrade, out yourGrade);
                        if (yourGrade >= 0 && yourGrade <= 100 && numberCheck == true)
                        {
                            yourGrade = Convert.ToInt32(newGrade);
                            Console.WriteLine(gradeBook(yourGrade));
                            gradeList.Add(yourGrade);
                        }
                    } while (yourGrade < 0 || yourGrade > 100 || numberCheck != true);
                    Console.WriteLine();
                }

                // This section gives the user the option to continue using the application

                Console.Write("Would you like to continue? Enter Y or N: ");
                do
                {
                    choice = Console.ReadLine().ToLower();
                    if (choice != "y" && choice != "n")
                    {
                        Console.WriteLine("Please enter Y or N: ");
                    }
                    else if (choice == "n")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Thank you for using our grading system. You entered the following grades today: ");
                        foreach (int item in gradeList)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.WriteLine();
                        keepTesting = false;
                        return;
                    }
                } while (choice != "y");


            } while (keepTesting == true);


        }

        // This is the method being used to return the correct letter grade based on the user input.

        static string gradeBook(int grade)
        {
            if (grade < 60)
            {
                return "You have failed and received a F. Please see me!";
            }
            if (grade < 63)
            {
                return "You have received a D-.";
            }
            if (grade < 65)
            {
                return "You have received a D.";
            }
            if (grade < 67)
            {
                return "You have received a D+.";
            }
            if (grade < 70)
            {
                return "You have received a C-.";
            }
            if (grade < 77)
            {
                return "You have received a C.";
            }
            if (grade < 80)
            {
                return "You have received a C+.";
            }
            if (grade < 82)
            {
                return "You have received a B-.";
            }
            if (grade < 86)
            {
                return "You have received a B.";
            }
            if (grade < 88)
            {
                return "You have received a B+.";
            }
            if (grade < 91)
            {
                return "You have received an A-.";
            }
            if (grade < 99)
            {
                return "You have received an A.";
            }
            else
            {
                return "You have received an A+. How much extra credit did you do for that?";
            }

        }
    }
}
