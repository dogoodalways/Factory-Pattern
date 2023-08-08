using FactoryPattern;
using System;
using System.Text;

namespace Factories
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What kind of vehicle do you want to make, car or motorcycle?");
            var userInput = Console.ReadLine();

            VehicleFactory factory = new VehicleFactory();
            IVehicle myVehicle = factory.CreateVehicle(userInput);

            myVehicle.Drive();

            Console.WriteLine("Lets make another vehicle");
            userInput = Console.ReadLine();



        }
    }          
}
            
    

