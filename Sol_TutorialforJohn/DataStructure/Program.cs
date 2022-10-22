using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A list is a collection of types objects such as strings and integers.
            // They can be accessed through index which starts from 0 instead of 1. In this case
            // "Japchae" has an index of 0 and so on and so forth.
            string[] koreanDishes = new string[] { "Japchae", "Bulgogi", "Bibimbap", "Kimchi"};
            Stack<string> myStack = new Stack<string>(koreanDishes);

            // Adds item into the top of the stack.
            // The push function basically pushes the item we put into the function at the top of the stack 
            // which should be viewed with the Peek() function.
            myStack.Push("Adobo");
            myStack.Push("Tinula");
            myStack.Push("Chicken Adobo");

            // Prints the item at the top of the stack.
            //Console.WriteLine(myStack.Pop());
            //Console.WriteLine(myStack.Peek());

            Methods();
        }

        static void Methods()
         {
            // Stores the expression we fucking have for the question.
            var someValue = "(6/3+2)*(9-3)";

            // Will be used for appending for output.
            string postfixExpression = "";

            // Just a stack.
            var stack = new Stack<char>();


            // Loops through a number of times based on the expression's length and each character is stored in the variable called 'c'.
            foreach (char c in someValue)
            {

                // Validates if each individual character 'c' is an operator.
                if (c.ToString() == "(" || c.ToString() == "/" || c.ToString() == "+" || c.ToString() == "*" || c.ToString() == "-" || c.ToString() == ")")
                {
                    // Will pop the the existing operator if c is + and will be pushed into the stack.
                    if (c.ToString() == "+")
                    {
                        postfixExpression += stack.Pop();
                        stack.Push(c);
                    }
                    // Pops all the values in the stack if 'c' is ')' and all values except '()' is appended into postfixExpression.
                    else if (c.ToString() == ")")
                    {
                        int someInt = stack.Count;
                        for (int i = 0; i < someInt; i++)
                        {
                            if (stack.ElementAt(0).ToString() == "(" || stack.ElementAt(0).ToString() == ")")
                                stack.Pop();
                            else postfixExpression += stack.Pop().ToString();
                        }
                    }
                    else stack.Push(c);
                }
                // Appends 'c' if it's not an operator.
                else postfixExpression += c.ToString();
            }

            Console.WriteLine(postfixExpression);
            Console.ReadLine();
        }
    }
}
