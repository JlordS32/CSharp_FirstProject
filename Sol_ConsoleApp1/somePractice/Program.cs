using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 2, 8, 15, 16, 23, 42};
            string[] friends = new string[5];
            Console.Write("Enter a name: ");
            friends[0] = Console.ReadLine();
            friends[1] = "Kelly";
            Console.WriteLine(luckyNumbers[1]);
            Console.WriteLine(friends[0] + friends[1]);
            SayHi(friends[0]);
            Console.WriteLine($"Hello {someThing("Jesus")}");
            Console.ReadLine();
        }

        static void SayHi(string name)
        {
            Console.WriteLine("Hello User! " + name);
        }

        static string someThing(string name)
        {
            string newString = name;
            return newString;
        }
    }
}
