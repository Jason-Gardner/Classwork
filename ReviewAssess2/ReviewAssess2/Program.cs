using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewAssess2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int> { 132, 2, 4, 11, 21, 13, 22, 122 };
            Console.WriteLine(ReviewAssessment.GetMax(numList));
            int picker = 11;
            ReviewAssessment.InsertNumber(numList, picker);
            string sentence = "This is the best place to be.";
            string[] words = ReviewAssessment.NewArray(sentence);
            foreach (var word in words)
            {
                Console.WriteLine(word + " ");
            }
        }
    }
}
