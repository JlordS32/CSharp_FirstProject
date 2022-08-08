using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numberGrid =
            {
                {1, 2 },
                {3, 4 },
                {5, 6 },
                {7, 8 }
            };

            Console.WriteLine(numberGrid[3, 1]);

            int[,] theArray = new int[2, 4]
            {
                {1, 2, 3, 4}, {5, 6, 7, 8}
            };
            Console.WriteLine("The value is {0}.", theArray[1, 2]);

            Console.ReadLine();
        }
    }
}
