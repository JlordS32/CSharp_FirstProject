using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Animal
    {
        public string species { get; set; }
        public string colour { get; set; }
        public string _animalName;

        public Animal(string Aspecies = "No species", string Acolour = "No colour")
        {
            species = Aspecies;
            colour = Acolour;
        }

        public void Writing()
        {
            Console.WriteLine("The species is {0} and has a {1} colour", species, colour);
        }
    }
}
