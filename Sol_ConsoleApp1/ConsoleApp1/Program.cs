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
            Console.ReadLine();
        }
    }
}
