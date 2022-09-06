using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(9);
            Console.WriteLine(square.GetArea());

            Console.WriteLine(square.SomeText());
            Console.ReadLine();
        }
    }

    abstract class Shape
    {
        public abstract int GetArea();
        public abstract string SomeText();
    }

    class Square : Shape
    {
        public int _sides;

        public Square()
        {

        }

        public Square(int x) => _sides = x;

        public override int GetArea() => _sides * _sides;

        // Without abstract class
        /* public int GetArea()
        {
            return _sides * _sides;
        }*/

        public override string SomeText() => "Hello world!";
    }
}
