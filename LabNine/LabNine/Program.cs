using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace LabNine
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Parallel arrays to pull information from
            List<string> studentName = new List<string> {
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

            List<string> studentCity = new List<string> {
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

            List<string> studentFood = new List<string> {
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

            List<string> studentBand = new List<string> {
                "Metallica",
                "The Clash",
                "Eminem",
                "John Denver",
                "Terror",
                "Animals as Leaders",
                "Swing Kids",
                "Johann Sebastian Bach",
                "Kenny G",
                "The Notorious B.I.G." };

            List<Student> ClassList = new List<Student>();

            for (int i = 0; i < studentName.Count; i++)
            {
                ClassList.Add(new Student());
            }

            for (int z = 0; z < ClassList.Count; z++)
            {
                ClassList[z].name = studentName[z];
                ClassList[z].city = studentCity[z];
                ClassList[z].food = studentFood[z];
                ClassList[z].band = studentBand[z];
            }

            // Introduces program, asks user if they want a list printed of all students
            Console.WriteLine("Welcome to the Grand Circus Student Directory!");
            Console.WriteLine("**********************************************");
            Console.WriteLine();
            bool repeat = true;

            classList(ClassList);
            Console.WriteLine();

            do
            {
                // Ask for user input of student number
                Console.WriteLine($"Enter a student number between 1 - {ClassList.Count}:");
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

                // Makes sure the input falls within our array
                try
                {
                    Console.WriteLine($"Student number {studID} is {ClassList[studID - 1].name}.");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("That student does not exist, please enter a number between 1 - 10.");
                    continue;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("That student does not exist, please enter a number between 1 - 10.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input! Please enter a number between 1 - 10.");
                }
                Console.WriteLine();

                // Determines what the user wants to know about the student
                do
                {
                    Console.WriteLine($"What would you like to know about {ClassList[studID - 1].name}? You can say hometown, favorite band or favorite food.");
                    infoChoice = Validator(Console.ReadLine().ToLower(), "(hometown)|(favorite food)|(favorite band)");
                    
                    if (infoChoice == "hometown")
                    {
                        Console.WriteLine($"{ClassList[studID - 1].name} is from {ClassList[studID - 1].city}.");
                    }
                    if (infoChoice == "favorite food")
                    {
                        Console.WriteLine($"{ClassList[studID - 1].name}'s favorite food is {ClassList[studID - 1].food}.");
                    }
                    if (infoChoice == "favorite band")
                    {
                        Console.WriteLine($"{ClassList[studID - 1].name}'s favorite band is {ClassList[studID - 1].band}.");
                    }

                    // Determines whether the user wants more information about the student chosen
                    Console.WriteLine();
                    Console.WriteLine("Would you like to know more? Please enter yes or no.");
                    learnMore = Validator(Console.ReadLine().ToLower(), "(y)|(n)|(yes)|(no)");
                    
                } while (learnMore == "y" | learnMore == "yes");

                Console.WriteLine();
                Console.WriteLine("Would you like to add another student? Please enter yes or no.");
                string addStudent = Console.ReadLine().ToLower();

                while (idCheck(learnMore, "(y)|(n)|(yes)|(no)") == false)
                {
                    learnMore = correctInput();
                }

                if (addStudent == "y" | addStudent == "yes")
                {
                    Console.WriteLine();
                    ClassList.Add(newStudent());
                    Console.WriteLine();
                    classList(ClassList);
                }

                // Determine whether the user wants to know about another student or end the program
                Console.WriteLine();
                Console.WriteLine("Would you like to know more about another student? Please enter yes or no.");
                learnMore = Console.ReadLine().ToLower();
                while (idCheck(learnMore, "(y)|(n)|(yes)|(no)") == false)
                {
                    learnMore = correctInput();
                }
                if (learnMore == "no" | learnMore == "n")
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

        public static string correctInput()
        {
            Console.Write("Please enter a correct input for the question asked: ");
            return Console.ReadLine().ToLower();
        }

        public static Student newStudent()
        {
            Student newStudent = new Student();
            Console.WriteLine("Please enter a name for your student: ");
            string name = Console.ReadLine();
            if (idCheck(name, "[A-Za-z']") == true)
            {
                newStudent.name = name;
            }
            else
            {
                while (idCheck(name, "[A-Za-z']") == false)
                {
                    name = correctInput();
                }
                newStudent.name = name;
            }
            Console.WriteLine("Please enter a hometown for your student: ");
            string city = Console.ReadLine();
            if (idCheck(city, "[A-Za-z'.]") == true)
            {
                newStudent.city = city;
            }
            else
            {
                while (idCheck(city, "[A-Za-z'.]") == false)
                {
                    city = correctInput();
                }
                newStudent.name = name;
            }
            Console.WriteLine("Please enter a favorite food for your student: ");
            string food = Console.ReadLine();
            if (idCheck(food, "[A-Za-z]") == true)
            {
                newStudent.food = food;
            }
            else
            {
                while (idCheck(food, "[A-Za-z]") == false)
                {
                    food = correctInput();
                }
                newStudent.food = food;
            }
            Console.WriteLine("Please enter a favorite band for your student: ");
            string band = Console.ReadLine();
            if (idCheck(band, "[A-Za-z0-9]") == true)
            {
                newStudent.band = band;
            }
            else
            {
                while (idCheck(band, "[A-Za-z0-9]") == false)
                {
                    band = correctInput();
                }
                newStudent.band = band;
            }
            return newStudent;
        }

        public static void classList(List<Student> ClassList)
        {
            Console.WriteLine("Would you like to see the class list?");
            string classChoice = Console.ReadLine().ToLower();
            ClassList.Sort((x, y) => x.name.CompareTo(y.name));

            while (idCheck(classChoice, "(y)|(n)|(yes)|(no)") == false)
            {
                classChoice = correctInput();
            }

            if (classChoice.StartsWith("y"))
            {
                Console.WriteLine();
                Console.WriteLine("Fall 2045 C#12.0 Cohort");
                Console.WriteLine("***********************");
                Console.WriteLine();
                for (int index = 0; index < ClassList.Count; index++)
                {
                    Console.WriteLine((index + 1) + $". {ClassList[index].name}");
                }
            }
            Console.WriteLine();
        }

        public static string Validator(string entry, string pattern)
        {
            while (idCheck(entry, pattern) == false)
            {
                entry = correctInput();
            }
            return entry;
        }
    }
}
