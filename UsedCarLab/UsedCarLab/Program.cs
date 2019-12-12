using System;
using System.Collections.Generic;
using System.IO;

namespace UsedCarLab
{
    class Program
    {
        // CSV - Comma Separated Value
        //
        // if we write a car object, it should show up as 
        // BMW, M5, 2002

        static void Main(string[] args)
        {
            List<Car> carInventory = new List<Car>()
            // Scope of the carlist 
            {
                //new newCar(), new usedCar()
            };
            addCar(carInventory);
            printList(carInventory);

            
        }

        static void addCar(List<Car> carList)
        {
            string choice;
            do
            {
                Console.WriteLine("Would you like to add a new or used car?");
                choice = Console.ReadLine();
                newCar thatCar = new newCar();
                usedCar thisCar = new usedCar();
                if (choice == "new")
                {
                    thatCar.makeCar(thatCar);
                    carList.Add(thatCar);
                }
                if (choice == "used")
                {
                    thisCar.makeCar(thisCar);
                    carList.Add(thisCar);
                }
            } while (choice != "no");
        }

        public static void printList(List<Car> carInventory)
        {
            //writer.WriteLine("New Cars:");
            foreach (Car car in carInventory)
            {
                if (car is newCar)
                {
                    newCar thisCar = new newCar();
                    thisCar = car as newCar;
                    thisCar.CarToCSV();
                    Console.WriteLine(thisCar.CSVToCar()); 
                    
                }
            }
            //writer.WriteLine("Used Cars:");
            foreach (Car car in carInventory)
            {
                if (car is usedCar)
                {
                    Console.WriteLine(car.Definition());
                    //writer.WriteLine(car.Definition());
                }
            }
            //writer.Close();
        }
    }
}
