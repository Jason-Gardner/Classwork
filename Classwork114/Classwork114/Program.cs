using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Classwork114
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> newList = new List<string> { "this", "is", "a", "list" };
            //newList.Add("buffalo");
            //newList.Sort();
            //for (int index = 0; index < newList.Count; index++)
            //{
            //    Console.Write(newList[index] + " ");
            //}

            Console.WriteLine("Please enter a number: ");
            string input = userInput();
            int number = 0;

            number = validInput(input);
            number = Add(number, 10);
            Console.WriteLine(number);
            double newdouble = Add(number, 2.2);
            Console.WriteLine(newdouble);           
            
        }

        public static string userInput()
        {
            return Console.ReadLine();
        }

        public static int validInput(string input)
        {
            int number = 0;
            try
            {
                number = int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input.");
            }
            catch (Exception)
            {
                Console.WriteLine("An error has occurred.");
            }

            return number;
        }

        public static int Add (int num1, int num2)
        {
            return num1 + num2;
        }

        public static double Add (int num1, double num2)
        {
            return num1 + num2;
        }
    }
}
