using System;

namespace Exercise17
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 10, i, space, k = 0;

            for (i = 1; i <= rows; ++i, k=0)
            {
                for (space = 1; space<=rows-i; space++)
                {
                    Console.Write(" ");
                }
                while (k != i)
                {
                    Console.Write("* ");
                    k++;
                }
                if (i < rows)
                {
                    Console.WriteLine();
                }
            }

           



        }
    }
}

