using System;
using System.Collections.Generic;
using System.Text;

namespace LabTen
{
    class Circle
    {
        public double radius;

        public Circle()
        {
        }

        public Circle(double radius)
        {
        }

        public double CalculateCircumference(double radius)
        {
            return (2 * Math.PI * radius);
        }

        public string CalculateFormattedCircumference(double radius)
        {
            return "The circumference of your circle is " + FormatNumber(CalculateCircumference(radius));
        }

        public double CalculateArea(double radius)
        {
            return Math.PI * Math.Pow((radius), 2);
        }

        public string CalculateFormattedArea(double radius)
        {
            return "The area of your circle is " + FormatNumber(CalculateArea(radius));
        }

        private string FormatNumber(double x)
        {
            return (String.Format("{0:0.00}", x));
        }
    }
}
