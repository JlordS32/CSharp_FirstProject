using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            for (int i = 1; i <= 20; i+=2)
            {
                Console.WriteLine(i);

            }

            Console.Clear();
            int[] LuckyNumbers = { 12, 23, 4, 43, 5, 64 };

            for (int i = 0; i < LuckyNumbers.Length; i++)
            {
                Console.WriteLine(LuckyNumbers[i]);
            }
            
            Console.ReadLine();
            thePower();
        }

        static void thePower()
        {
            Console.WriteLine(Math.Pow(5, 3));
            Console.ReadLine();
        }
    }
}
