using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> movies = new List<string> (){ "The Lion King", "Toy Story", "Finding Nemo" };

            movies.Insert(2, "The Little Mermaid");
            movies.Add("Frozen");

            Console.WriteLine(movies[2]);

            foreach (string movie in movies)
            {
                Console.WriteLine(movie);
            }

            List<int> someNumber = new List<int> (){ 1, 2, 3, 4, 5};

            Console.ReadLine();
            Console.Clear();

            movies.RemoveAt(0);
            movies.Remove("Toy Story");
            foreach (string movie in movies)
            {
                Console.WriteLine(movie);
            }
            Console.ReadLine();

            Console.Clear();

            movies.Sort();
            int items = movies.Count(); 
            foreach (string movie in movies)
            {
                Console.WriteLine("{0} {1}", movie, items);
            }
            Console.ReadLine();
            movies.Clear();
            items = movies.Count();
            Console.WriteLine(items);
            Console.ReadLine();




        }
    }
}
