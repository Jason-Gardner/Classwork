using System;

namespace Classwork1028
{
    class Program
    {
        const int MAX_SIZE = 10;
        static void Main(string[] args)
        {
            //char[] charArray;
            //string input = "hello everyone";
            //charArray = new char[input.Length];
            //for(int i = 0; i < charArray.Length; i++)
            //{
            //    charArray[i] = input[i];
            //    Console.Write(charArray[i]);
            //}

            //string[] answers = { "y", "Y", "n", "N" };

            //string sum = "lol";
            //for (int index = 0; index < answers.Length; index++)
            //{
            //    sum += answers[index];
            //    Console.WriteLine($"Word: {sum}");
            //}

            //string[] words = { "Hello", "World", "!" };
            //for (int index = 0; index < words.Length; index++)
            //{
            //    if (words[index] != "!")
            //    {
            //        Console.Write(words[index] + " ");
            //    }
            //    else
            //    { 
            //        Console.Write(words[index]);
            //    }
            //}

            //int[] numArray = new int[10];

            //for (int index = 0; index < numArray.Length; index++)
            //{
            //    numArray[index] = 5;
            //}

            //foreach (int num in numArray)
            //{
            //    // This is read only, cannot assign values
            //}

            //Array[] arrays = new Array[10];

            int[] intArray = { 23, 23, 32, 34 };
            int[] newArray = intArray;
            // These two arrays are now referencing the same memory area so they are the same
            newArray[2] = 12;
            // This will print 12 because we are referencing the same space
            Console.WriteLine(intArray[2]);

            int[][] numArray = new int[5][];

            
            
           
        }
    }
}
