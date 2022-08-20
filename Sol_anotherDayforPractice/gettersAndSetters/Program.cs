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
            Movie Avengers = new Movie("The Avangers", "Joss Whedon", "PG-13");
            Movie Shrek = new Movie("Shrek", "Adam Adamson", "PG");

            Shrek.Rating = "Dog";
            Console.WriteLine(Shrek.Rating);

            Console.ReadLine();
        }
    }
}
