using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupLab11
{
    class Movie
    {
        private string Title;
        private string Category;

        public string title
        {
            get { return Title; }
            set { Title = value; }
        }

        public string category
        {
            get { return Category; }
            set { Category = value; }
        }

        public Movie (string title, string category)
        {
            Title = title;
            Category = category;
        }
    }
}
