using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLab
{
    public class usedCar : Car
    {
        private double Mileage;

        public double mileage
        {
            get { return Mileage; }
            set { Mileage = value; }
        }

        public usedCar(string Make, string Model, int Year, double Mileage) //Pass in the necessary values
        {
            make = Make;
            model = Model;
            year = Year;
            mileage = Mileage;
        }

        public usedCar()
        {

        }

        public override string Definition()
        {
            return $"{base.Definition()}{make} {model} {year} {mileage}";
        }

        public override Car makeCar(Car thatCar)
        {
            usedCar thisCar = thatCar as usedCar;
            Console.WriteLine("Enter the make of the car: ");
            thisCar.make = Console.ReadLine();
            Console.WriteLine("Enter the model of the car: ");
            thisCar.model = Console.ReadLine();
            Console.WriteLine("Enter the year of the car: ");
            thisCar.year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the mileage of the car: ");
            thisCar.mileage = Convert.ToInt32(Console.ReadLine());
            return thisCar;
        }

        public void CarToCSV()
        {
            StreamWriter writer = new StreamWriter(@"..\..\..\CarLotDB.txt");

            writer.WriteLine(this.make, this.model, this.year);
        }

    }
}
