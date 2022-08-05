using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string personName = "George";
            //int personAge;
            //personAge = 71;

            //Console.WriteLine($"There once was a man named {personName}");
            //Console.WriteLine($"He was {personAge} years old");
            //personName = "Mike";
            //Console.WriteLine($"He really liked the name {personName}");
            //Console.WriteLine(String.Format("But didn't liked being {0}.", personAge));

            //Console.ReadLine();

            string daBebe = "bebe";
            string phrase = $"Meme is the best {daBebe}.";
            bool ifTrue = phrase.Contains("bebe");
            if(ifTrue is true)
            {
                Console.WriteLine("There's a bebe.");
            }
            else
            {
                Console.WriteLine("There's no bebe.");
            }
            Console.WriteLine(phrase.IndexOf('z'));
            Console.WriteLine(Math.Pow(3, 3));
            Console.WriteLine(Math.Round(123843.12));
            Console.WriteLine(Math.Abs(99));
            Console.ReadLine();

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine(string.Format("\nHello {0} {1}", name, lastName));
            Console.ReadLine();
        }
    }
}
