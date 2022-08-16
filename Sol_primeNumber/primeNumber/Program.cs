using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number: ");

            if (int.TryParse(Console.ReadLine(), out int theValue))
            {
                for (int i = 2; i <= theValue / 2; i++)
                {
                    if (theValue % i == 0)
                    {
                        Console.WriteLine("It's not a prime number.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("It's a prime number.");
                    }
                }
                Console.ReadLine();
            }
        }
    }
}
