namespace OOP
{
    internal class Program
    {
        //A class in C# is a blue print for creating objects
        //It defines a set of properties (data attributes)
        // and methods that an object of that class will have
        static void Main(string[] args)
        {   
            //creating an instance of car in the main method called audi
            Car audi = new Car();
            //this is how can access a method from another class
            audi.Drive();
            Car bmw = new Car();//creating another instance of car
            audi.Stop();
            Console.WriteLine("Press 1 if you want the car to stop");

            string userInput = Console.ReadLine();
            if (userInput.Equals("1"))
            {
                audi.Stop();
            }
            else {
                Console.WriteLine("Car keeps driving");
            }
            
        }
    }
}