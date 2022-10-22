using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
    internal class Program
    {
        static void Main()
        {
            int[] num = { 2, 9, 11, 7 };
            int output = 0;

            for (int i = 0; i < num.Length; i++)
            {
                output = num[i] + num[i+1];

                if (output == 9)
                {
                    Console.WriteLine("[{0}, {1}]", Array.IndexOf(num, num[i]), Array.IndexOf(num, num[i+1]));
                    break;
                }
                else Console.WriteLine("Nothing");
            }

            Console.ReadLine();
        }
    }
}
