using System;

namespace Exercise4344
{
    class Program
    {
        static void Main(string[] args)
        {
            //int xC, yC;
            //Console.Write("Please enter the X value: ");
            //xC = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please enter the Y value: ");
            //yC = Convert.ToInt32(Console.ReadLine());
            //Point yourPoint = new Point(xC,yC);
            //Console.WriteLine($"Your point is ({yourPoint.xCoord}, {yourPoint.yCoord}).");

            Point yourPoint = new Point(4, 5);
            yourPoint.getInfo(yourPoint.xCoord);
            Coordinate newCoord = new Coordinate();
            newCoord.xCoord = 6;
            newCoord.xCoord = 9;
            newCoord.coord.xCoord = ((yourPoint.xCoord + newCoord.xCoord) / 2);
            newCoord.coord.yCoord = ((yourPoint.yCoord + newCoord.yCoord) / 2);
        }
    }
}
