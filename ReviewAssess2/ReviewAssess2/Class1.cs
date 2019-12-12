using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewAssess2
{
    class ReviewAssessment
    {
        public static string[] NewArray(string input)
        {
            string[] wordArray = input.Split(' ');
            return wordArray;
        }

        public static List<int> InsertNumber(List<int> list, int num)
        {
            if (list.Contains(num))
            {
                Console.WriteLine("Your entry was already in the list.");
                return list;
            }
            list.Add(num);
            Console.WriteLine($"You have successfully added {num}!");
            return list;
        }

        public static int GetMax(List<int> list)
        {
            return list.Max();
        }
    }
}
