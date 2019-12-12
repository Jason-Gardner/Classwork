using System;
using System.Collections.Generic;
namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
          
            List<string> genre = new List<string>()
            {
            "Horror", "Animated", "Drama", "Scifi"
            };

            Movie yourMovie = new Movie{ };
            List<Movie> movieList = yourMovie.createList();
            
            movieList.Sort((a,b)=> a.Title.CompareTo(b.Title));

            Console.WriteLine("Hi welcome to the Movie database!\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("\nPlease select a number from the list below");

                int i = 1;
                foreach (string index in genre)
                {
                    Console.WriteLine($"{i}: {index}");
                    i++;
                }

                int userNumber = Movie.GetNumber(genre, movieList);
                Console.WriteLine("\nHere are your movies from the selected genre: ");

                foreach (Movie movie in movieList)
                {
                    if (movie.Catagory == userNumber - 1)
                    {
                        Console.WriteLine(movie.Title);
                    }
                }
                repeat = Movie.Repeater();
            }
            Console.WriteLine("\nGoodBye!");
            return;
        }
    }
}
