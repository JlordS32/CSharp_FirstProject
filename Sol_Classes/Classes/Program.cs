using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Classes
{
    internal class Program
    {
        static void Main()
        {
            Address address = new Address("13/2", "Libya Place", "Marsfield", "NSW", "2122");

            address.GetAddress();

            Console.ReadLine();

            #region PracticeOne
            /*
            Person personOne = new Person(18, "Belva");

            Console.WriteLine(personOne.DescribeYourself());
            Console.WriteLine(personOne.Age);

            Animal animal = new Animal();
            animal.colour = "black";
            animal._animalName = "blackie";
            animal.species = "cat";

            animal.Writing();
            Console.WriteLine(animal._animalName);

            Person p = new Person(100, "old");
            Console.WriteLine(p.DescribeYourself());
            */
            #endregion
            #region Practice Two
            /*
            Person person1 = new Person();

            try
            {
                person1.Age = -20;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            person1.Name = "Jaylou";
            Console.WriteLine(person1.DescribeYourself());
            Console.ReadLine();
            */
            #endregion
        }
    }
}
