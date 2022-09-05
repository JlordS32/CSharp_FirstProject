using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace arrayLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] courseCodes = new string[6];

            courseCodes[0] = "ICT20115";
            courseCodes[1] = "ICT30118";
            courseCodes[2] = "ICT40315";
            courseCodes[3] = "ICT40518";
            courseCodes[4] = "ICT50615";
            courseCodes[5] = "ICT50718";

            string[] courseNames = new string[6];
            courseNames[0] = "Certificate 2 in IT";
            courseNames[1] = "Certificate 3 in IT";
            courseNames[2] = "Certificate 4 in web";
            courseNames[3] = "Certificate 4 in programming";
            courseNames[4] = "Diploma in web development";
            courseNames[5] = "Diploma in software development";

            Console.WriteLine("Course codes\n");
            for (int i = 0; i < courseCodes.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i+1, courseCodes[i]);
            }

            Console.Write("\nPlease select a course code 1, 2, 3, 4, 5, or 6: ");
            bool isInt = int.TryParse(Console.ReadLine(), out int intChoice);

            while (isInt == false)
            {
                Console.Write("Invalid! enter again: ");
                isInt = int.TryParse(Console.ReadLine(), out int i);
                intChoice = i;
            }
            if (isInt == true)
            {
                Console.WriteLine("The course name for the code: {0}", courseNames[intChoice]);
            }
            Console.ReadLine();
            

        }
    }

    class TheArrays
    {
        public int newInt;
        public void AMain()
        {
            string[] aArray = { "apple", "grape", "banana", "grapes", "strawberries" };

            for (int i = 0; i < aArray.Length; i++)
            {
                Console.WriteLine("Index no. {0}: {1}", i, aArray[i]);
            }

            int[,] numArray = {
                                { 44, 34, 53, 5, 3 },
                                { 34, 36, 76, 45, 45}
                              };

            int[,] anotherArray;
            int[,] arrayuwu;
            int[] scores;

            scores = new int[4] { 2, 3, 4, 5 };


            anotherArray = new int[3, 2]
            {
                {1, 2 },
                {3, 5 },
                {5, 6 }
            };

            // you can only new int if you declare an empty array

            arrayuwu = new int[2, 3]{
                        { 1, 2, 3 },
                        { 3, 4, 5 }
                        };


            Console.WriteLine(numArray[0, 4]);

            Console.ReadLine();
        }
    }
}
