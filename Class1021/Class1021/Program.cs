using System;

namespace Class1021
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Prompt user for input
            //Console.Write("Please enter a number: ");
            //string userInput = Console.ReadLine();
            //int input;
            //bool tester = int.TryParse(userInput, out input);
            //while (tester == false)
            //{
            //    Console.WriteLine("You entered an invalid number. Please enter a new number: ");
            //    userInput = Console.ReadLine();
            //    tester = int.TryParse(userInput, out input);
            //}
            //Console.WriteLine("This will output squares of all numbers up to the input.");
            //for (int i = 1; i <= input; i++)
            //{
            //    // Calculate and output squares up to user input
            //    Console.Write($"{i * i} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("This will output cubes of all numbers up to the input.");
            //for (int i = 1; i <= input; i++)
            //{
            //    // Calculate and output cubes up to user input
            //    Console.Write($"{i * i * i} ");
            //}

            //// Calculate the sum of all numbers up to the input

            //int addUp = 0;
            //Console.WriteLine();
            //Console.WriteLine("This will print out the sum of all numbers up to the input.");
            //for (int i = 1; i <= input; addUp += i, i++)
            //{
                
            //}
            //Console.WriteLine($"The sum of all numbers up to {input} is {addUp}.");

            //Take first input
            int firstNum = 0, secNum = 0;

            do
            {
                Console.Write("Please enter your first number: ");
                string fnum = Console.ReadLine();
                firstNum = numChecker(fnum);

                Console.Write("Please enter your second number: ");
                string snum = Console.ReadLine();
                secNum = numChecker(snum);
                int newSum = 0;
                
                if (firstNum <= secNum && firstNum > 0 && secNum > 0)
                {
                    for (int i = firstNum; i <= secNum; newSum += i, i++)
                    {
                     
                    }
                    Console.WriteLine($"The sum of all numbers between {firstNum} and {secNum} is {newSum}.");
                    return;
                }
                if (firstNum > secNum && firstNum > 0 && secNum > 0)
                {
                    for (int i = firstNum; i >= secNum; newSum += i, i--)
                    {

                    }
                    Console.WriteLine($"The sum of all numbers between {firstNum} and {secNum} is {newSum}.");
                    return;
                }
                Console.WriteLine("Your numbers were not valid.");
                Console.WriteLine();
            } while (firstNum != -1 && secNum != -1);
        }

        public static int numChecker (string test)
        {
            int placeHold = -1;
            bool testing = int.TryParse(test, out placeHold);
            if (testing == true)
            {
                return int.Parse(test);
            }
            else
            {
                return placeHold;
            }
        }
    }
}
