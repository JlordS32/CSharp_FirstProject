using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstnum, secondnum, thirdnum;
            Console.Write("First number: ");
            firstnum = int.Parse(Console.ReadLine());
            Console.Write("\nSecond number: ");
            secondnum = int.Parse(Console.ReadLine());
            Console.Write("\nThird number: ");
            thirdnum = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("The biggest number is");
            Console.ReadLine();
            Console.WriteLine(GetMax(firstnum, secondnum, thirdnum));
            Console.ReadLine();
        }

        static int GetMax(int num1, int num2, int num3)
        {
            int result; 
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2>= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }
            return result;
        }
    }
}
