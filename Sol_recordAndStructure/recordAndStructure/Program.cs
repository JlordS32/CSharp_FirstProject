using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recordAndStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person jesus = new Person("Jaylou", "Rasonabe");

            Console.WriteLine(jesus.firstName + jesus.lastName);

            Console.ReadLine();
        }
    }
}
