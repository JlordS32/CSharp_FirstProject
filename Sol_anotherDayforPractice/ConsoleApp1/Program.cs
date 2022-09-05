using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDict = new Dictionary<int, string>()
            {
                {1, "one" },
                {2, "two" },
                {3, "three" },
                
            };

            string[] myString = { "jesus", "christ", "is", "dead" };
            int[,] myInt = { { 1, 2, 3 }, 
                             { 4, 5, 6 } };

            Console.WriteLine(myDict[1]);
            Console.ReadLine();

            Console.WriteLine(myString[1]);
            Console.WriteLine(myInt[1,1]);

            Console.ReadLine();
        }
    }
}
