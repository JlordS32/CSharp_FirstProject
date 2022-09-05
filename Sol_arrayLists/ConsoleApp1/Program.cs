using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        public static string[] orderNames = { "Cheese Burger", "Hawaiian Burger", "Chicken Burger", "Vegetarian Burger",
                                            "Supreme Pizza ", "Hawaiian Pizza", "Chicken Pizza", "Vegetarian Pizza", "Cheese Pizza" };

        public static double[] orderPrices = { 2.50, 3.00, 2.80, 2.90, 12.50, 13.00, 20.00, 18.00, 19.50 };
        static void Main(string[] args)
        {
            ConfirmOrder();
        }

        static void ConfirmOrder()
        {
            string confirmOrder = "none";
            while (confirmOrder != "yes" || confirmOrder != "no")
            {
                Console.Write("Hi, would you like to order [yes/no]: ");
                confirmOrder = Console.ReadLine().ToLower();

                if (confirmOrder == "yes")
                {
                    Console.Clear();
                    Menu();
                    break;
                }
                else
                {
                    Console.WriteLine("Thanks for coming!");
                    Console.ReadLine();
                    break;
                }
            }

        }

        static void Menu()
        {
            int count = 0;

            for (int i = 0; i < orderNames.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Burgers\n");
                }

                else if (i == 4)
                {
                    Console.WriteLine("\nPizza\n");
                }

                Console.WriteLine("{0}. {1}", i + 1, orderNames[i]);
            }
            Console.Write("\nPlease select your order: ");

            bool ifOrder = int.TryParse(Console.ReadLine(), out int orderNumber);

            while (ifOrder == false)
            {
                count++;
                if (count == 3)
                {
                    Console.Write("Do you still want to order? [yes/no]: ");
                    string continueOrder = Console.ReadLine();

                    if (continueOrder == "yes" || continueOrder == "y")
                    {
                        Console.Clear();
                        Menu();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
;
                }
                Console.Write("Please input the correct number according to the menu: ");
                ifOrder = int.TryParse(Console.ReadLine(), out orderNumber);
            }

            Console.Write("Please enter a quantity: ");
            bool isInt = int.TryParse(Console.ReadLine(), out int orderQty);

            Console.WriteLine("\nThe cost is: ${0}", Calculate(orderNumber, orderQty).ToString());
        }

        static double Calculate(int orderNum, int orderQty)
        {
            double result = orderPrices[orderNum] * orderQty;
            return result;
        }
    }
}
