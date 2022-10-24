using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Program
    {
        public static int result = 0;
        static void Main(string[] args)
        {
            Console.WriteLine(count_partitions(9, 4));

            Console.ReadLine();
        }

        static void Multiply(int n)
        {
            if (n == 0) return;

            else
            {
                Multiply(n - 1);
                Console.WriteLine(n);
            }
        }

        static int SumToZero(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            else
            {
                return n + SumToZero(n - 1);
            }
        }

        static int grid_paths(int n, int m)
        {
            if (n == 1 || m == 1) return 1;

            else
            {
                int result = grid_paths(n, m - 1) + grid_paths(n - 1, m);
                return result;
            }
        }

        static int count_partitions(int n, int m)
        {
            if (n == 0)
                return 1;
            else if (m == 0 || n < 0)
                return 0;
            else
                return count_partitions(n - m, m) + count_partitions(n, m - 1);
        }
    }
}
