using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LabEleven
{
    class Program
    {

        public static void Main(string[] args)
        {
            string choice = "yes";
            int appSelect;

            List<Movie> movieList = new List<Movie> { };
            stockBuilder(movieList);
            List<Movie> rentedList = new List<Movie> { };

            Console.WriteLine("Hello! Welcome to the Grand Circus Movie Library!");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Call 281-330-8004 for Movie Recommendations 24/7!");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Please select an option: \n 1) Add a movie ***MANAGER ONLY*** \n 2) Browse the collection and rent a movie \n 3) Return a movie (CURRENTLY BROKEN)");

            string userInput = Console.ReadLine();
            while (dataCheck(userInput) == false)
            {
                Console.WriteLine("Invalid input. Please try again.");
                userInput = Console.ReadLine();
            }

            appSelect = Convert.ToInt32(userInput);

            do
            {
                while (appSelect == 1 && choice.ToLower() == "yes")
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter the manager password: ");
                    string passNum = Console.ReadLine();
                    if (Regex.IsMatch(passNum, "password"))
                    {
                        addMovie(movieList);
                        Console.WriteLine("Would you like to add another movie?");
                        choice = Console.ReadLine();
                        continue;
                    }
                    if (Regex.IsMatch(passNum, "manager"))
                    {
                        Console.WriteLine("INCORRECT INPUT, SYSTEM MELTDOWN.");
                        Console.Beep(1300, 1300);
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password.");
                    }
                }

                while (appSelect == 2 && (choice.ToLower() == "yes" | choice.ToLower() == "search"))
                {
                    rentMovie(movieList, rentedList);
                    Console.WriteLine("Would you like to rent another movie?");
                    choice = Console.ReadLine();
                }

                Console.WriteLine("Would you like to do something else?");
                choice = Console.ReadLine();
                if (choice.ToLower() == "yes")
                {
                    Console.WriteLine("Please select an option: \n 1) Add a movie ***MANAGER ONLY*** \n 2) Browse the collection and rent a movie \n 3) Return a movie (CURRENTLY BROKEN)");
                    userInput = Console.ReadLine();
                    while (dataCheck(userInput) == false)
                    {
                        Console.WriteLine("Invalid input. Please try again.");
                        userInput = Console.ReadLine();
                    }
                    appSelect = int.Parse(userInput);
                    continue;
                }
                else
                {
                    return;
                }
            } while (appSelect == 1 | appSelect == 2 | appSelect == 3);
        }

        static public void movieSearch(string search, List<Movie> movieList)
        {
            Console.WriteLine("Here are your search results: ");
            foreach (Movie movie in movieList)
            {
                if (Regex.IsMatch(movie.title, search))
                {
                    Console.WriteLine(movie.title);
                }
                if (Regex.IsMatch(movie.genre, search))
                {
                    Console.WriteLine(movie.title);
                }
                if (Regex.IsMatch(Convert.ToString(movie.year), search))
                {
                    Console.WriteLine(movie.title);
                }
            }
        }

        static public List<Movie> stockBuilder(List<Movie> movieList)
        {
            Movie Titanic = new Movie("Titanic", "romance", 1999);
            Movie JurassicPark = new Movie("Jurassic Park", "romance", 1997);
            Movie TrueLies = new Movie("True Lies", "action", 1995);
            Movie KnockedUp = new Movie("Knocked Up", "comedy", 2001);
            Movie Spaceballs = new Movie("Spaceballs", "comedy", 1985);
            Movie TheMatrix = new Movie("The Matrix", "action", 2013);
            Movie FSM = new Movie("Forgetting Sarah Marshall", "comedy", 2009);
            Movie TheDeparted = new Movie("The Departed", "action", 2010);
            Movie PulpFiction = new Movie("Pulp Fiction", "drama", 2000);

            movieList.Add(Titanic);
            movieList.Add(JurassicPark);
            movieList.Add(TrueLies);
            movieList.Add(KnockedUp);
            movieList.Add(Spaceballs);
            movieList.Add(TheMatrix);
            movieList.Add(FSM);
            movieList.Add(TheDeparted);
            movieList.Add(PulpFiction);

            return movieList;
        }

        static public void addMovie(List<Movie> movieList)
        {
            Movie newMovie = new Movie { };
            Console.WriteLine("Please enter your movie's title: ");
            newMovie.title = Console.ReadLine();
            Console.WriteLine("Please enter your movie's genre: ");
            newMovie.genre = Console.ReadLine();
            Console.WriteLine("Please enter your movie's release year: ");
            string newYear = Console.ReadLine();
            newMovie.year = Convert.ToInt32(newYear);
            movieList.Add(newMovie);
            Console.WriteLine();
        }

        static public void rentMovie(List<Movie> movieList, List<Movie> rentedList)
        {
            string search;
            Console.WriteLine("Great! Would you like to search by title, genre or release date?");
            search = Console.ReadLine();
            if (search == "title")
            {
                Console.WriteLine("Please enter a search term: ");
                movieSearch(Console.ReadLine(), movieList);

            }
            if (search == "genre")
            {
                Console.WriteLine("Please enter the corresponding number to pick a genre:");
                Console.WriteLine("1) Action\n2) Romance\n3) Comedy\n4) Horror\n5) Sci-fi\n6) Family");
                movieSearch(Console.ReadLine(), movieList);
            }
            if (search == "release" | search == "release date" | search == "date")
            {
                Console.WriteLine("Please enter a release year: ");
                movieSearch(Console.ReadLine(), movieList);
            }
            Console.WriteLine("Please select the title of the movie you would like to rent, or type SEARCH to keep searching.");
            string choice = Console.ReadLine();
            foreach (Movie movie in movieList)
            {
                if (Regex.IsMatch(movie.title, choice))
                {
                    movie.available = 'n';
                    rentedList.Add(movie);
                    Console.WriteLine($"You have rented {choice}.");
                }
            }
            movieList.RemoveAll(m => m.available == 'n');
        }

        static public bool dataCheck(string input)
        {
            do
            {
                try
                {
                    int checkNum = int.Parse(input);
                }
                catch (FormatException)
                {
                    return false;
                }
                catch (NullReferenceException)
                {
                    return false;
                }
                catch (ArgumentNullException)
                {
                    return false;
                }
                if (int.Parse(input) > 3)
                {
                    return false;
                }
                return true;
            } while (false);
        }
    }
}

