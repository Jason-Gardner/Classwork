using System;

namespace Class1021b
{
    class Program
    {
        static void Main(string[] args)
        {
            bool countCheck = false;
            do
            {
                Console.WriteLine("Hello! Please enter a word or phrase: ");
                string input = Console.ReadLine();
                
                if (input.Length >= 10)
                {
                    Console.WriteLine("The last ten characters are: ");
                    for (int i = (input.Length - 10); i < input.Length; i++)
                    {
                        Console.Write(input[i]);
                    }
                    countCheck = true;
                }
                else
                {
                    Console.WriteLine("You didn't enter enough chracters.");
                    Console.WriteLine();
                }
            }
            while (countCheck == false);

        }
    }
}
