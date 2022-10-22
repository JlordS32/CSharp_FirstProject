using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ChallengeNum2
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Please enter a roman number: ");
            string input = Console.ReadLine().ToUpper();
            int output = 0;

            var romanNumbers = new Dictionary<string, int>
            {
                ["I"] = 1,
                ["V"] = 5,
                ["X"] = 10,
                ["L"] = 50,
                ["C"] = 100,
                ["D"] = 500,
                ["M"] = 1000,
            };

            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (i == 0)
                        output += romanNumbers[input[i].ToString()];
                    else if (i >= 1)
                    {
                        if (romanNumbers[input[i].ToString()] > romanNumbers[input[i - 1].ToString()])
                        {
                            output += romanNumbers[input[i].ToString()] - (romanNumbers[input[i - 1].ToString()] * 2);
                        }
                        else output += romanNumbers[input[i].ToString()];
                    }
                }

                Console.WriteLine(output);
            }

            catch (Exception)
            {
                Console.WriteLine("Not a roman value.");

                Console.ReadLine();
                Environment.Exit(0);
            }

            Main();


        }
    }
}
