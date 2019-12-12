using System;
using System.Text.RegularExpressions;

namespace LabTen
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = false;
            int circleCount = 0;

            Console.WriteLine("Welcome to the Grand Circus Circle Factory!");
            do
            {
                makeCircle();
                circleCount++;
                repeat = keepGoing();
            } while (repeat == true);

            Console.WriteLine($"You created {circleCount} circles today!");
            return;
        }

        static public double Validator(string radius)
        {
            while (Regex.IsMatch(radius, "([!0-9]*)") == true)
            {
                Console.Write("Invalid input. Please enter a number: ");
                radius = Console.ReadLine();
            }

            return Convert.ToDouble(radius);
        }

        static public void makeCircle()
        {
            string myRadius;
            Circle myCircle = new Circle();
            do
            {
                Console.WriteLine("------------------------------------");
                Console.Write("Please enter the radius of your circle: ");
                myRadius = Console.ReadLine();
                Console.WriteLine();

                try
                {
                    myCircle.radius = double.Parse(myRadius);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Null not allowed.");
                    continue;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Null not allowed.");
                    continue;
                }
                
            } while (double.TryParse(myRadius, out myCircle.radius) == false);
            printOutput(myCircle);
        }

        static public void printOutput(Circle myCircle)
        {
            Console.WriteLine(myCircle.CalculateFormattedArea(myCircle.radius));
            Console.WriteLine(myCircle.CalculateFormattedCircumference(myCircle.radius));
            Console.WriteLine();
        }

        static public bool keepGoing()
        {
            Console.Write("Would you like to make another circle? Please enter yes or no: ");
            string yourChoice = Console.ReadLine().ToLower();
            while (!Regex.IsMatch(yourChoice, "(yes)|(y)|(no)|(n)"))
            {
                Console.Write("Please enter a valid choice, yes or no: ");
                yourChoice = Console.ReadLine();
            }
            if (Regex.IsMatch(yourChoice, "(yes)|(y)"))
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
