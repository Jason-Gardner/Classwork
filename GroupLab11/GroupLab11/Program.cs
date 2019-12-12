using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GroupLab11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            //Initialize a list of Movies
            while (repeat)
            {
                List<Movie> movieList = listBuilder();
                List<string> catList = new List<string>() { "animated", "drama", "horror", "scifi" };

                //Take user input for category
                Console.WriteLine("What category would you like to search for?");
                Console.WriteLine("You can select a number from the following:\n1) ANIMATED\n2) DRAMA\n3) HORROR\n4) SCIFI");
                string userInput = Validator(Console.ReadLine().ToLower(), "@[(1)|(2)|(3)|(4)]");
                int numInput = int.Parse(userInput);
                //Validation?

                //Search the list of movies to match user input to category
                foreach (Movie movie in movieList)
                {
                    if (movie.category == catList[numInput-1])
                    {
                        //Print movies from that category to the console
                        Console.WriteLine(movie.title);
                    }
                }
                repeat = repeatApp();
            }

            //Do you want to continue?

        }

        static List<Movie> listBuilder()
        {
            List<Movie> movieList = new List<Movie>();
            Movie One = new Movie("Friday the 13th", "horror");
            Movie Two = new Movie("Star Wars", "scifi");
            Movie Three = new Movie("The Departed", "drama");
            Movie Four = new Movie("Up", "animated");
            Movie Five = new Movie("Scarface", "drama");

            movieList.Add(One);
            movieList.Add(Two);
            movieList.Add(Three);
            movieList.Add(Four);
            movieList.Add(Five);
            movieList.Sort((x, y) => x.title.CompareTo(y.title));

            return movieList;
            
        }

        static public bool repeatApp()
        {
            Console.WriteLine("Would you like to search again?");
            string input = Validator(Console.ReadLine(), "@[(yes)|(y)|(no)|(n)]");
            if (Regex.IsMatch(input, "(yes)|(y)"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool idCheck(string ID, string pattern)
        {
            if (Regex.IsMatch(ID, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static string Validator(string entry, string pattern)
        {
            while (idCheck(entry, pattern) == false)
            {
                entry = correctInput();
            }
            return entry;
        }

        public static string correctInput()
        {
            Console.Write("Please enter a correct input for the question asked: ");
            return Console.ReadLine().ToLower();
        }
    }
}
