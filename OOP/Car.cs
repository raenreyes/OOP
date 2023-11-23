using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Car
    {
        //private member variable
        private string _name;
        private int _hp;
        private string _color;

        //this is a public property
        public string Name {
            get { return _name; } //this is the get accesser
            //this takes the value that we entered for it
            set
            {
                if (value == string.Empty)
                {
                    _name = "NO NAME SET";
                }
                else
                {
                    _name = value;
                } //this is the set accesser
            }
        }
        public Car()
        {
            _name = "Car";
            _hp = 5;
            _color = "Red";
            Console.WriteLine(_name + " was created");
        }

        public Car(string name, int hp = 0)
        {
            _name = name;
            _hp = hp;
            _color = "Blue";
            Console.WriteLine(_name + " was created");
            Drive();
        }

        public Car(string name, int hp, string color)
        {
            _name = name;
            _hp = hp;
            _color = color;
            Console.WriteLine(_name + " was created");
            Drive();

        }
        private void Drive()
        {
            Console.WriteLine(_name + " is driving");
        }
        public void Stop()
        {
            Console.WriteLine(_name + " now stopped!");
        }
        public void Details()
        {
            Console.WriteLine("My " + _color + " " + _name + " has an hp of " + _hp);
        }
    }
}
