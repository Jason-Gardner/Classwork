using System;
using System.Collections.Generic;
using System.Text;

namespace LabEleven
{
    public class Movie
    {
        private string Title;
        private string Genre;
        public int year;
        public char available = 'y';

        public string title
        {
            get { return Title; }
            set { Title = value; }
        }

        public string genre
        {
            get { return Genre; }
            set { Genre = value; }
        }

        public Movie()
        {

        }

        public Movie(string Title, string Genre, int Year)
        {
            title = Title;
            genre = Genre;
            year = Year;
        }

        public Movie(string Title, string Genre)
        {
            title = Title;
            genre = Genre;
        }
    }
}
