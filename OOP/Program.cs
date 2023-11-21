namespace OOP
{
    internal class Program
    {
       
        static void Main(string[] args)
        {   
            //creating an instance of car in the main method called audi
            Car audi = new Car("Audi A4",760,"Blue");
            //this is how can access a method from another class
            audi.Details();
            audi.Drive();
            Car bmw = new Car("BMW M5",350,"Yellow");//creating another instance of car
            bmw.Details();
            bmw.Drive();

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