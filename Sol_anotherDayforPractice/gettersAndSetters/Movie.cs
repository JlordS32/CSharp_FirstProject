using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace gettersAndSetters
{
    internal class Movie
    {
        public string title;
        public string director;
        private string rating;
        public static int movieCount = 0;


        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;

            movieCount++;
        }

        public string Rating
        {
            get
            {
                return rating;
            }
            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R"
                    || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }

        public int MovieCount()
        {
            return movieCount;
        }

    }
}
