using System;

namespace LabTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // This console application calculates the area, perimeter and volume of a room based on user inputs.
            // This is done using methods to calculate the totals based on the inputs and return a rounded answer on the console.

            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");
            Console.WriteLine("---------------------------------------------------------");

            // Initialization of our variables
            bool continueApp = true;
            string choice;
            decimal roomLength, roomWidth, roomHeight;

            do
            {
                Console.WriteLine();
                Console.Write("Please enter the length of the room in feet: ");
                roomLength = Decimal.Parse(Console.ReadLine());
                Console.Write("Please enter the width of the room in feet: ");
                roomWidth = Decimal.Parse(Console.ReadLine());
                Console.Write("Please enter the height of the room in feet: ");
                roomHeight = Decimal.Parse(Console.ReadLine());

                Console.WriteLine("Area: " + roomArea(roomLength, roomWidth) + " square feet");
                Console.WriteLine("Perimeter: " + roomPer(roomLength,roomWidth) + " feet");
                Console.WriteLine("Volume: " + roomVol(roomLength,roomLength,roomHeight) + " cubic feet");
                Console.WriteLine();

                Console.Write("Would you like to continue? Enter Y or N: ");
                choice = Console.ReadLine().ToLower();
                while (choice != "n" && choice != "y")
                {
                    Console.Write("Incorrect input, please type Y or N: ");
                    choice = Console.ReadLine().ToLower();
                }
                if (choice == "n")
                {
                    continueApp = false;
                    Console.WriteLine("Thank you for using the application. Goodbye!");
                    return;
                }

            } while (continueApp == true);

            return;
        }

        // Methods that allow us to do the calculations for area, perimeter and volume.
        static string roomArea (decimal len, decimal wid)
        {
            string newArea = String.Format("{0:N2}", (len * wid));
            return newArea;
        }

        static string roomPer (decimal len, decimal wid)
        {
            string newPer = String.Format("{0:N2}", (2 * (len + wid)));
            return newPer;
        }

        static string roomVol (decimal len, decimal wid, decimal height)
        {
            string newVol = String.Format("{0:N2}", (len * wid * height));
            return newVol;
        }
    }
}
