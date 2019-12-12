using System;
using System.Text.RegularExpressions;

namespace LabSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Data Entry Terminal!");
            Console.WriteLine("#################################################");
            Console.WriteLine();
            
            // Checks name, email, phone number and date
            nameCheck();
            mailCheck();
            numCheck();
            dateCheck();

            // Checks html tags
            tagCheck();
        }
        
        public static void nameCheck()
        {
            bool checker = false;
            string yourName;

            while (checker == false)
            {
                Console.WriteLine("Please enter your name: ");
                yourName = Console.ReadLine();

                if (Regex.IsMatch(yourName, @"^([A-Z]{1})(['A-Za-z]{0,29})"))
                {
                    Console.WriteLine("Valid input!");
                    checker = true;
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Sorry, that is not a valid name!");
                    Console.WriteLine();
                }
            }
        }

        public static void mailCheck()
        {
            bool checker = false;
            string yourEmail;

            while (checker == false)
            {
                Console.WriteLine("Please enter your email: (example: person@mail.net)");
                yourEmail = Console.ReadLine();

                if (Regex.IsMatch(yourEmail, @"^([A-Z]|[a-z]|[0-9]){5,30}@([A-Z]|[a-z]|[0-9]){5,10}.\w{2,3}"))
                {
                    Console.WriteLine("Valid input!");
                    checker = true;
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Sorry, that is not a valid email!");
                    Console.WriteLine();
                }
            }
        }

        public static void numCheck()
        {
            bool checker = false;
            string yourNum;

            while (checker == false)
            {
                Console.WriteLine("Please enter your phone number: (example: XXX-XXX-XXXX) ");
                yourNum = Console.ReadLine();

                if (Regex.IsMatch(yourNum, @"^\d{3}-\d{3}-\d{4}$"))
                {
                    Console.WriteLine("Valid input!");
                    checker = true;
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Sorry, that is not a valid phone number!");
                    Console.WriteLine();
                }
            }
        }

        public static void dateCheck()
        {
            bool checker = false;
            string yourDate;

            while (checker == false) 
            {
                Console.WriteLine("Please enter today's date: (example: DD/MM/YYYY)");
                yourDate = Console.ReadLine();

                if (Regex.IsMatch(yourDate, @"^([0][1-9]|[1][0-9]|[2][0-9]|[3][0-1])/([0][1-9]|[1][0-2])/([0][0-9][0-9][0-9]|[1][0-9][0-9][0-9]|[2][0-9][0-9][0-9])$"))
                {
                    Console.WriteLine("Valid input!");
                    checker = true;
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Sorry, that is not a valid date!");
                    Console.WriteLine();
                }
            }
        }

        public static void tagCheck()
        {
            bool checker = false;
            string yourCode;

            while (checker == false)
            {
                Console.WriteLine("Please enter your code containing html tags: ");
                yourCode = Console.ReadLine();

                if (Regex.IsMatch(yourCode, @"(\<(\/)?(\w)*(\d)?\>)"))
                {
                    Console.WriteLine("Valid input!");
                    checker = true;
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Sorry, that is not valid code!");
                    Console.WriteLine();
                }
            }
        }
    }
}
