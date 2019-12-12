using System;

namespace Class1016
{
    class Program
    {
        static void Main(string[] args)
        {
            //string num = "HELLO";
            //num.ToLower();

            //if (num == "hello")
            //{
            //    Console.WriteLine("hi!");
            //}
            //else if (num == "HELLO")
            //{
            //    Console.WriteLine("HELLO");
            //}
            //else
            //{
            //    Console.WriteLine("Bye!");
            //}

            //int num = 3;
            //switch (num % 2 == 0)
            //{
            //    case true:
            //        Console.WriteLine("even");
            //        break;
            //    default:
            //        Console.WriteLine("odd");
            //        break;
            //}

            //int num = 0;

            //while (num < 5)
            //{
            //    if (num == 4)
            //    {
            //        Console.WriteLine($"Hello {num}");
            //        num++;
            //    }

            //    num++;

            //}

            //do
            //{
            //    Console.WriteLine("Hello do while");
            //} while (0 != 0);

            //string newString = "Hello my new C# students!";
            //for (int i = 0; i < newString.Length; i++)
            //{
            //    Console.WriteLine(newString[i]);
            //}

            //foreach (char letter in newString)
            //{
            //    Console.WriteLine(letter);
            //}



            // Exercise 6 from workbook
            string answer;
            do
            {
                Console.WriteLine("Hello World!");
                Console.WriteLine("Would you like to continue? Type Y or N and press enter.");
                answer = Console.ReadLine().ToLower();
                if (answer == "n")
                {
                    Console.WriteLine("Goodbye!");
                    return;
                }
                else if (answer != "y")
                {
                    Console.WriteLine($"You entered {answer}. Please try again.");
                    answer = "y";
                }
            } while (answer == "y");

            
             


            // Lab 3 from workbook
            //int numAnswer;
            //bool realAnswer = true;
            //Console.WriteLine("Please enter your name:");
            //string yourName = Console.ReadLine();
            //bool keepGoing = true;
            
            //while (realAnswer == true)
            //{
            //Console.WriteLine($"{yourName}, please enter a number between 1 and 100");
            //numAnswer = Convert.ToInt32(Console.ReadLine());
            //    if (numAnswer > 0 && numAnswer < 101)
            //    {
            //        do
            //        {
            //            if (numAnswer % 2 == 0)
            //            {
            //                if (numAnswer < 25)
            //                {
            //                    Console.WriteLine($"{yourName}, your number is even and less than 25.");
            //                    keepGoing = false;
            //                    realAnswer = false;
            //                }
            //                else if (numAnswer > 25 && numAnswer <= 60)
            //                {
            //                    Console.WriteLine($"{yourName}, your number is even and between 26 and 60, inclusive.");
            //                    keepGoing = false;
            //                    realAnswer = false;
            //                }
            //                else
            //                {
            //                    Console.WriteLine($"{yourName}, your number is even.");
            //                    keepGoing = false;
            //                    realAnswer = false;
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine($"{yourName}, your number is odd.");
            //                keepGoing = false;
            //                realAnswer = false;
            //            }
            //        } while (keepGoing == true);
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{yourName}, please follow the instructions listed.");
            //    }

            //}
            //Console.WriteLine($"{yourName}, thank you for using the number sorting console. Goodbye!");
            //Environment.Exit(0);
        }
    }
}
