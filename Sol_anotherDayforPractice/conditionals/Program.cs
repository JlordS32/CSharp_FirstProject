using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Is he tall or short? : ");
            string uwu = Console.ReadLine();

            switch (uwu)
            {
                case "tall":
                    Console.Clear();
                    Console.WriteLine("He's pretty tall");
                    break;
                case "short":
                    Console.Clear();
                    Console.WriteLine("He's short");
                    break;
                default:
                    Console.WriteLine("Nothing to comment...");
                    break;
            }

            Console.ReadLine();
        }
    }
}
