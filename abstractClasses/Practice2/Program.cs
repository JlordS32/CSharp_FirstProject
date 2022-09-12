using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass.Uwu();
            // comment
            Console.ReadLine();
        }
    }

    abstract class BaseClass
    {
        protected int _x = 100;
        protected int _y = 100;

        public abstract void AbstractMethod();

        public abstract int X { get; }
        public abstract int Y { get; }
    }

    class DerivedClass : BaseClass
    {
        public override void AbstractMethod()
        {
            _x++;
            _y++;
        }

        public override int X => _x + 10;

        public override int Y => _y + 10;

        public static void Uwu()
        {
            var o = new DerivedClass();
            o.AbstractMethod();
            Console.WriteLine($"x = {o.X}, y = {o.Y}");
        }
    }
}
