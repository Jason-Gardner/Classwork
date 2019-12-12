using System;

namespace Class1017
{
    class Program
    {
        static void Main(string[] args)
        {
            string.Compare("hello", "world");
            string firstName = "Steve";
            bool truth = firstName.Equals("Frank");
            Console.WriteLine(truth);

            int finder = firstName.IndexOf('e');
            string newString = firstName.Replace('e', 'o');
            Console.WriteLine(newString);

            //StringBuilder strBuff = new StringBuilder("test!");
            //strBuff.Append("\t Super!");

            // First and last instance of a character
            string input = "Hel lo";
            string sentence = "Hello World!";
            Console.WriteLine(input.IndexOf('l'));
            Console.WriteLine(input.LastIndexOf('l'));
            int index = input.IndexOf('l');

            // Checks for bool on ending of string
            bool endsWith = input.EndsWith("lo");
            Console.WriteLine(endsWith);

            //Substring usage
            string anotherOne = input.Substring(0,input.IndexOf("o"));
            Console.WriteLine(anotherOne);
            string newString2 = input.Substring(index, 1);
            Console.WriteLine(newString2);

            //string replace
            string anotherString = input.Replace(" ", "");
            Console.WriteLine(input);
            Console.WriteLine(anotherString);

            //use string split to get array of strings
            string [] words = sentence.Split(' ');
            Console.WriteLine(words[0]);
            foreach (string item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
