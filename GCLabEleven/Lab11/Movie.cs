using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace Lab11
{
    public enum genreNum
    {
        horror, animated, drama, scifi
    }

    public class Movie
    {
        private string title;
        private int catagory;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public int Catagory
        {
            get;
            set;
        }

        public Movie()
        {

        }

        public Movie(string title, int catagory)
        {
            Title = title;
            Catagory = catagory;
        }

        public static int GetNumber(List<string> list, List<Movie> listTwo)
        {
            int userReply = 0;
            bool repeat = true;
            while (repeat)
            {
                try
                {
                    userReply = int.Parse(Console.ReadLine());
                    object test = listTwo[userReply];
                    repeat = false;
                }
                catch (Exception)
                {
                    Console.WriteLine($"Please enter a number between 1 and {list.Count}!");
                }
            }
            return userReply;
        }

        public static bool Repeater()
        {
            bool repeat = true;
            Console.WriteLine("\nDo you wish to continue?");
            while (repeat)
            {
                string reply = Console.ReadLine();
                if (string.IsNullOrEmpty(reply))
                {
                    Console.WriteLine("Please enter a yes or no");
                }
                else if (Regex.IsMatch(reply.ToLower(), @"(y)|(yes)"))
                {
                    repeat = false;
                    return true;
                }
                else if (Regex.IsMatch(reply.ToLower(), @"(n)|(no)"))
                {
                    repeat = false;
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter a yes or no");
                }

            }
            return true;
        }

        public List<Movie> createList()
        {
            List<Movie> movieList = new List<Movie> { };
            StreamReader sr = new StreamReader(@"..\..\..\movielist.txt");
            List<string> listBuild = new List<string>();
            string line = sr.ReadLine();

            while (line != null)
            {
                listBuild.Add(line);
                line = sr.ReadLine();
            }

            foreach (string entry in listBuild)
            {
                string[] entryBuild = entry.Split(',');
                movieList.Add(new Movie(entryBuild[0], (int)Enum.Parse(typeof(genreNum),entryBuild[1])));
            }
            sr.Close();
            return movieList;
        }


    }
}
