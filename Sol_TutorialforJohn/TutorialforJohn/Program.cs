using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TutorialforJohn
{
    internal class Program
    {
        static void Main()
        {
            Manager manager1 = new Manager(100000, "Jaylou", "Rasonabe", 20, "male");

            manager1.PrintDetails();
            manager1.PrintSalary();

            Console.ReadLine();
        }
    }

    public class Employee
    {
        protected string _firstname;
        protected string _lastName;
        protected int _age;
        protected string _gender;
        public Employee(string firstname, string lastname, int age, string gender)
        {
            _firstname = firstname;
            _lastName = lastname;
            _age = age;
            Gender = gender;
        }

        public Employee()
        {

        }
        public string Gender
        {
            get { return _gender; }
            set { 
                if (value == "male" || value == "female")
                {
                    _gender = value;
                }

                else
                {
                    _gender = "Gay";
                }
            }
        }

        public void PrintDetails()
        {
            Console.WriteLine(
                "First Name: {0}\n" +
                "Last Name: {1}\n" +
                "Gender: {2}\n" +
                "Age: {3}", 
                _firstname, _lastName, _gender, _age
                );
        }
    }

    public class Manager : Employee
    {
        private int _salary;

        public Manager(int salary, string name, string lastname, int age, string gender)
        {
            _firstname = name;
            _lastName = lastname;
            _age = age;
            Gender = gender;
            _salary = salary;
        }

        public void PrintSalary()
        {
            Console.Write(_firstname + " " + _lastName + " is currently paid " + _salary + " annually");
        }
    }
}


