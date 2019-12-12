using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLab
{
    // Made an abstract base class and defined some of the characteristics to pass down
    public abstract class Car
    {
        // Make private fields to hold data
        private int Year;
        private string Make;
        private string Model;

        // Make a public property that allows us to access the private field
        public string make 
        {
            get { return Make; }
            set { Make = value; }
        }

        public string model 
        {
            get { return Model; }
            set { Model = value; }
        }

        public int year
        {
            get { return Year; }
            set { Year = value; }
        }

        // Made a virtual method that we will later override in a derived class
        public virtual string Definition()
        {
            return "Vehicle: ";
        }

        public virtual Car makeCar(Car thatCar)
        {
            Console.WriteLine("Enter the make of the car: ");
            thatCar.make = Console.ReadLine();
            Console.WriteLine("Enter the model of the car: ");
            thatCar.model = Console.ReadLine();
            Console.WriteLine("Enter the year of the car: ");
            thatCar.year = Convert.ToInt32(Console.ReadLine());
            return thatCar;
        }
    }
}
