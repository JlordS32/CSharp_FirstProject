using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QueryArrayList();
            Console.ReadLine();
        }

        static void QueryStringArray()
        {
            string[] dogs = {"K 9", "Brian Griffin",
                             "Scooby Doo ", "Old Yeller", "Rin Tin Tin",
                             "Benji", "Charlie B. Barkin", "Lassie",
                             "Snoopy" };

            var dogSpaces = from dog in dogs
                            where dog.Contains(" ")
                            orderby dog descending
                            select dog;

            foreach (string dog in dogSpaces)
            {
                Console.WriteLine(dog);
            }
        }

        static int[] QueryIntArray()
        {
            int[] nums = { 5, 10, 15, 20, 25, 30, 35 };

            Console.WriteLine(nums.GetType());

            var gt20 = from num in nums
                       where num > 20
                       orderby num
                       select num;

            foreach (int num in gt20)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Get Type: {0}", gt20.GetType());

            var listGT20 = gt20.ToList<int>();
            var arrayGT20 = gt20.ToArray<int>();
            Console.WriteLine(arrayGT20);

            nums[0] = 40;

            foreach (var i in gt20)
            {
                Console.WriteLine(i);
            }

            return arrayGT20;
        }

        static void QueryArrayList()
        {
            ArrayList famAnimals = new ArrayList()
            {
                new Animal
                {
                    Name = "Heidi",
                    Height = .8,
                    Weight = 18
                },

                new Animal
                {
                    Name = "Shrek",
                    Height = 4,
                    Weight = 130
                },

                new Animal
                {
                    Name = "Congo",
                    Height = 3.8,
                    Weight = 90
                }
            };

            Animal soemthing = new Animal()
            {
                Name = "Jesus",
                Height = 90,
                Weight = 4,
            };

            Animal Frog = new Animal("Froggie", 90, 20);
            Console.WriteLine(Frog);

            var famAnimalEnum = famAnimals.OfType<Animal>();

            var smAnimals = from animal in famAnimalEnum
                            where animal.Weight <= 90
                            orderby animal.Name
                            select animal;

            foreach (var animal in smAnimals)
            {
                Console.WriteLine("{0} weights {1}", animal.Name, animal.Weight);
            }
        }

    }
}
