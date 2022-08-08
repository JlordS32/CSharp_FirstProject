using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter you name: ");
            string theName = Console.ReadLine();

            while (theName != "Jaylou")
            {
                Console.Clear();
                Console.Write("Please enter the right name: ");
                theName = Console.ReadLine();
            }

            Console.Clear();
            Console.WriteLine("You wrote the correct name. Congrats!");
            Console.ReadLine();
        }
    }   
}
