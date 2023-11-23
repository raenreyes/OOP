namespace OOP
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Car myCar = new Car();
            //set the name
            myCar.SetName("Bugatti");
            myCar.SetHP(1400);
            //then get the name and the hp
            Console.WriteLine("My car is a "+ myCar.GetName() + " and it has " + myCar.GetHP());
            myCar.Details();
            Car audi = new Car("Audi A4", 760);
            audi.Details();

            Car bmw = new Car("BMW M5", 350, "Yellow");
            bmw.Details();

            Console.WriteLine("Press 1 if you want the car to stop");

            string userInput = Console.ReadLine();
            if (userInput.Equals("1"))
            {
                audi.Stop();
            }
            else
            {
                Console.WriteLine("Car keeps driving");
            }

        }
    }
}