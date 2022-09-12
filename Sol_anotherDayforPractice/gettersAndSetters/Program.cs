using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gettersAndSetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie Avengers = new Movie("The Avangers", null, "PG-13");
            Movie Shrek = new Movie("Shrek", "Adam Adamson", "PG");
            Movie HarryPotter = new Movie("Harry Potter", "Some dude", "G");

            Console.WriteLine(Avengers.director);

            Shrek.Rating = "Dog";
            Console.WriteLine(Shrek.Rating);
            Console.WriteLine(Movie.movieCount);
            Console.WriteLine(Avengers.MovieCount());

            Console.ReadLine();
        }
    }
}
