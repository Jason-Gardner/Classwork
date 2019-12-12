using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaParlor
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Pizza Parlor");
            Console.WriteLine("****************************************\n");

            Console.WriteLine("Would you like to make a pizza today?");
            string useApp = Console.ReadLine();
            if (useApp.ToLower() == "yes")
            {

                Pizza newPizza = new Pizza();
                newPizza = Pizza.pizzaMaker(newPizza);
                Pizza.pizzaPrint(newPizza);
            }
            else
            {
                Console.WriteLine("Goodbye!");
                return;
            }
        }
    }
}
