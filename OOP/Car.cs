using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Car
    {   
        private string _name; 
        private int _hp;
        private string _color;
       

        public Car() { 
            _name = "Car";
            _hp = 0;
            _color = "Red";
            Console.WriteLine(_name + " was created");
        }

        public Car(string name, int hp = 0)
        {
            _name = name; 
            _hp = hp;
            _color = "Blue";
            Console.WriteLine(_name + " was created");
            Drive();//calling private method
        }
       
        public Car(string name, int hp, string color)
        {
            _name = name;
            _hp = hp;
            _color = color;
            Console.WriteLine(_name + " was created");
            Drive();//calling private method

        }

        private void Drive () //made this method private so it cant be called from the main class
        {
            Console.WriteLine(_name + " is driving");
        }
        public void Stop()
        {
            Console.WriteLine(_name + " now stopped!");
        }
        public void Details ()
        {
            Console.WriteLine("The " + _color + " " + _name + " has an hp of " + _hp);
        }
    }
}
