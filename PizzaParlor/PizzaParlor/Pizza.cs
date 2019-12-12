using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaParlor
{
    public enum Size
    {
        Small, Medium, Large, Party
    }

    class Pizza
    {
        private string pizzaType;
        private int size;
        private List<string> toppings;

        public string PizzaType
        {
            get { return pizzaType; }
            set { pizzaType = value; }
        }

        public int Size
        {
            get;
            set;
        }

        public List<string> Toppings
        {
            get { return toppings; }
            set { toppings = value; }
        }

        public static Pizza pizzaMaker(Pizza yourPizza)
        {
            string answer;
            Console.WriteLine("Please select the type of pizza you would like:");
            Console.WriteLine("Thin Crust, Deep Dish or Pan");
            yourPizza.pizzaType = Console.ReadLine();
            Console.WriteLine("Great! Please select a size: Small, Medium, Large or Party");
            yourPizza.size = (int)Enum.Parse(typeof (Size), Console.ReadLine());
            Console.WriteLine("Would you like to add any toppings to that?");
            answer = Console.ReadLine();
            if (answer.ToLower() == "yes")
            {
                getToppings(yourPizza);
            }
            return yourPizza;
        }

        private static Pizza getToppings(Pizza pizza)
        {
            List<string> toppings = new List<string> { "cheese" };
            bool repeat = true;
            do
            {
                Console.WriteLine("Please select from the list below:");
                Console.WriteLine("1) Pepperoni     2) Bacon");
                Console.WriteLine("3) Ham           4) Sausage");
                Console.WriteLine("5) Onions        6) Green Pepper");
                Console.WriteLine("7) Pineapple     8) Mushrooms");

                string choice = Console.ReadLine();
                toppings.Add(choice);
                Console.WriteLine("Would you like to add another topping?");
                choice = Console.ReadLine();
                if (choice.ToLower() == "no")
                {
                    repeat = false;
                }
            } while (repeat);

            pizza.toppings = toppings;
            return pizza;
        }

        public static void pizzaPrint(Pizza pizza)
        {
            if (pizza.size == 0)
            {
                Console.Write($"Small {pizza.pizzaType} with\n");
            }
            if (pizza.size == 1)
            {
                Console.Write($"Medium {pizza.pizzaType} with\n");
            }
            if (pizza.size == 2)
            {
                Console.Write($"Large {pizza.pizzaType} with\n");
            }
            if (pizza.size == 3)
            {
                Console.Write($"Party Size {pizza.pizzaType} with\n");
            }

            foreach (string top in pizza.Toppings)
            {
                Console.Write(top + " ");
            }
            Console.WriteLine(".");
        }
    }
}
