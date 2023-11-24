namespace OOP
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Name = "Toyota Tacoma";
            Console.WriteLine("My car max speed is " + myCar.MaxSpeed + " miles per hour!");
            myCar.SetSpeed = 78;
            myCar.Details();
          

        }
    }
}