using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeNumber
{
    internal class Program
    {
        static void Main()
        {
            bool isPrime = true;

            Console.Write("Enter a number: ");

            if (int.TryParse(Console.ReadLine(), out int theValue))
            {
                for (int i = 2; i <= theValue/2; i++)
                {
                    if (theValue % i == 0)
                    {
                        Console.WriteLine("{0} is not prime number", theValue);
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine("{0} is a prime number", theValue);
                }
            }
            Console.ReadLine();
            Main();
        }
    }
}
