using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace UsedCarLab
{
    // NewCar inherits from the Car class
    public class newCar : Car
    {
        public newCar(string Make, string Model, int Year) //Pass in the necessary values
        {
            make = Make;
            model = Model;
            year = Year;
        }

        public List<newCar> CSVToCar()
        {
            newCar ourCar = new newCar();
            List<string> carList = new List<string> { };
            List<newCar> thisList = new List<newCar> { };
            StreamReader sr = new StreamReader(@"C:\Users\Jason Gardner\Documents\Projects\ClassWork\UsedCarLab\UsedCarLab\CarLotDB.txt");
            string line = sr.ReadLine();

            //Hold split values in a string array
            while (line != null)
            {
                carList.Add(line);
                line = sr.ReadLine();
            }

            foreach (string csv in carList)
            {
                string[] thisLine = csv.Split(',');
                //ourCar.make = thisLine[0];
                //ourCar.model = thisLine[1];
                //ourCar.year = Convert.ToInt32(thisLine[2]);
                thisList.Add(new newCar(thisLine[0], thisLine[1], int.Parse(thisLine[2])));
            }

            return thisList;

        }

        enum CType
        {
            Ford = 1, Dodge, Toyota, Honda
        }

        public newCar()
        {

        }
        public override string Definition()
        {
            return $"{base.Definition()}{make} {model} {year}";
        }

        public void CarToCSV()
        {
            StreamWriter writer = new StreamWriter(@"C:\Users\Jason Gardner\Documents\Projects\ClassWork\UsedCarLab\UsedCarLab\CarLotDB.txt");

            string csv = $"{this.make},{this.model},{this.year}";
            //writer.WriteLine(this.make, this.model, this.year);
            writer.WriteLine(csv);

            writer.Close();
        }
    }
}
