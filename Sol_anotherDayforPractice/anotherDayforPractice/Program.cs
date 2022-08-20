using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace anotherDayforPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewBook bookOne = new NewBook();
            bookOne.title = "Harry Potter";
            bookOne.author = "Jk Rowling";
            bookOne.pages = 400;

            NewBook bookTwo = new NewBook();
            bookTwo.title = "Lord of the Rings";
            bookTwo.author = "Tolkein";
            bookTwo.pages = 700;

            NewBook bookThree = new NewBook("Harry Potter", "Jk Rowling", 400);

            Tree theOne = new Tree();
            theOne.tree = "Oak Tree";
            theOne.age = 1000;

            Console.WriteLine(theOne.tree);
            Console.WriteLine(bookOne.JkRowlling());
            Console.WriteLine(bookTwo.JkRowlling());

            Console.ReadLine();

            bookThree.title = "The Hobbit";

            Console.WriteLine(bookThree.title + bookThree.author + bookThree.pages);
            Console.ReadLine();
        }
    }

    class Tree
    {
        public string tree;
        public int age;
        public string colour;

        public Tree()
        {
            Console.WriteLine("This is a tree broo...", colour);
        }

        public Tree(string aTree, int aAge, string color)
        {
            tree = aTree;
            age = aAge;
            colour = color;
        }



    }
}