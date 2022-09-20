using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Net.Cache;

namespace Classes
{
    internal class Person
    {
        private int _age;
        private string _name;

        public Person()
        {
            
        }

        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Age must be a positive value.");
                }
                else
                {
                    _age = value;
                }
            }
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string DescribeYourself()
        {
            string desc;

            desc = $"My Name is {_name} and I'm {_age} years old.";

            return desc;
        }

        public string DescribeYourself(string somebody)
        {
            string desc;

            desc = $"Hello {somebody}, my name is {_name} and I'm {_age} years old.";

            return desc;
        }

        static public string SomeMethod()
        {
            return "The method is being used";
        }
    }
}
