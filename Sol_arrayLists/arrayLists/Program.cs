using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] aArray = { "apple", "grape", "banana", "grapes", "strawberries" };

            for (int i = 0; i < aArray.Length; i++)
            {
                Console.WriteLine("Index no. {0}: {1}", i, aArray[i]);
            }

            Console.ReadLine();
        }
    }
}
