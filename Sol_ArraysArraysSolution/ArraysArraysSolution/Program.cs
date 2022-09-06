using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysArraysSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = i+1;
            }

            foreach (int number in numbers)
            {
                Console.WriteLine("{0}: {1}", number, number * number);                               
            }

            Console.Write("Enter the upper limit of the numbers you'd like to square: ");
            
            if (int.TryParse(Console.ReadLine(), out int upperLimit))
            {
                int[] number2 = new int[upperLimit];

                for (int i = 0; i < upperLimit; i++)
                {
                    number2[i] = i+1;
                }

                foreach (int number in number2)
                {
                    Console.WriteLine("{0}: {1}", number, number * number);
                }

                Console.ReadLine();
            }

        }
    }
}
