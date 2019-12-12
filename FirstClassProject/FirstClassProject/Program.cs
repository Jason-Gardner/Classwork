using System;

namespace FirstClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
            string firstNumber = Console.ReadLine();

            int newNum = 0;
            int numberOne = 0;

            bool test = int.TryParse(firstNumber, out newNum);

            if (test == false)
            {
                Console.WriteLine("User entered " + firstNumber + " instead of numbers.");
            }
            else
            {
                numberOne = int.Parse(firstNumber[0].ToString());
                Console.WriteLine(numberOne);
            }
        }
    }
}
