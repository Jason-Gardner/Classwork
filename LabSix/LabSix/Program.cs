using System;
using System.Text.RegularExpressions;

namespace LabSix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduction text
            Console.WriteLine("Welcome to the Fabulous Grand Circus Casino!");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -");
            Console.Write("Would you like to try your luck and roll the dice? ");
            string userChoice = Console.ReadLine().ToLower();
            char letter = ' ';

            // Determine whether or not the user wants to use the application
            Console.WriteLine();
            while (char.TryParse(userChoice, out letter) == false || (userChoice != "y" && userChoice != "n"))
            {
                Console.WriteLine("Please enter Y or N: ");
                userChoice = Console.ReadLine().ToLower();
            }
            while (userChoice == "y")
            {
                // Initialize the dice face number variable
                bool reRoll = true;
                int userSides = 0;
                string choiceSides = " ";
                
                // Make sure there is a valid entry for the dice face
                while (int.TryParse(choiceSides, out userSides) != true)
                {
                    Console.Write("Please choose the number of sides for your dice between 4 - 100: ");
                    choiceSides = Console.ReadLine();
                    Console.WriteLine();
                    if (int.TryParse(choiceSides, out userSides) == true)
                    {
                        userSides = Convert.ToInt32(choiceSides);
                    }
                }

                // Set the sides of the dice, test for whether it matches the parameters
               
                if (userSides > 3 && userSides < 101)
                {
                    // Initialize the class to store information
                    Dice dice1 = new Dice();
                    Dice dice2 = new Dice();

                    dice1.sides = userSides;
                    dice2.sides = userSides;

                    // Methods to roll the dice
                    dice1.rolledNum = Roll(dice1.sides);
                    dice2.rolledNum = Roll(dice2.sides);

                    // Print the rolled numbers
                    Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><>");
                    Console.WriteLine();
                    Console.WriteLine($"          Dice 1:  {dice1.rolledNum}   Dice 2:  {dice2.rolledNum}");
                    Console.WriteLine();
                    Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><>");

                    // Display any special messages
                    Console.WriteLine();
                    DiceRollerApp(dice1, dice2);

                    // Check to see if the user would like to continue
                    Console.WriteLine("Would you like to roll again? ");
                    userChoice = Console.ReadLine().ToLower();
                    Console.WriteLine();
                    while (userChoice != "y" && reRoll == true)
                    {
                        if (userChoice == "n")
                        {
                            reRoll = false;
                        }
                        else
                        {
                            Console.WriteLine("Please select Y or N: ");
                            userChoice = Console.ReadLine().ToLower();
                        }
                    }
                }

            }
            Console.WriteLine("Thank you for visiting, goodbye!");
            return;

        }

        public static int Roll(int sides)
        {
            Random diceRoll = new Random();
            return diceRoll.Next(1, sides + 1);
        }

        public static void DiceRollerApp(Dice one, Dice two)
        {
            if (one.rolledNum == 1 && two.rolledNum == 1)
            {
                Console.WriteLine("*** SNAKE EYES ***");
            }
            if (one.rolledNum + two.rolledNum == 3 || one.rolledNum + two.rolledNum == 12)
            {
                Console.WriteLine("*** CRAPS ***");
            }
            if (one.rolledNum == 6 && two.rolledNum == 6)
            {
                Console.WriteLine("*** BOXCARS ***");
            }
            Console.WriteLine();
        }
    }

    public class Dice
    {
        public int sides;
        public int rolledNum;
    }
}
