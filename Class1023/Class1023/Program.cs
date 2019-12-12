using System;

namespace Class1023
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getFactor(24));
        }

        static long getFactor (long number)
        {
            if (number > 1)
            {
                return number * getFactor(--number);
            }

            return number;
        }
    }
}
