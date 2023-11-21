using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Car
    {   //underscore is good way on knowing its private
        //Member Variables 
        private string _name; //private field to store data
        private int _hp;
        private string _color;
        //Default constructor
        public Car(string name, int hp = 0, string color = "black")
        {
            _name = name; //assign it to out private field
            _hp = hp;
            _color = color;
            Console.WriteLine(name + " was created");
            
            
        }
        //Member Methods
        public void Drive ()
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
