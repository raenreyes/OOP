using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Car
    {   //Default constructor
        public Car() {
            Console.WriteLine("Car was created");
        }
        public void Drive ()
        {
            Console.WriteLine("Car is driving");
        }
        public void Stop()
        {
            Console.WriteLine("The car is now stopped!");
        }
    }
}
