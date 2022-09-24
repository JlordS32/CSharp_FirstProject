using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    internal class Program
    {
        // interface = defines a 'contract' that all the classes inheriting from should follow.

        // an interface declares 'what a class should have'
        // an inheriting class defines 'how it should do it'
        static void Main(string[] args)
        {
            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();

            fish.flee();
            fish.hunt();
            Console.ReadKey();
        }

        interface IPrey
        {
            void flee();
        }

        interface IPredator
        {
            void hunt();
        }

        class Rabbit : IPrey
        {
            public void flee()
            {
                Console.WriteLine("The rabbit runs away");
            }
        }

        class Hawk : IPredator
        {
            public void hunt()
            {
                Console.WriteLine("The hawk is searching for food");
            }
        }

        class Fish : IPredator, IPrey
        {
            public void flee()
            {
                Console.WriteLine("The fish swims away!");
            }

            public void hunt()
            {
                Console.WriteLine("The fish is searching for smaller fish");
            }
        }
    }
}
