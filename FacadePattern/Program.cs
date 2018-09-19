using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mechanic = new Mechanic("Shawn");
            var car = new Car();

            bool isSafe = car.IsSafeToDrive(mechanic);

            Console.WriteLine("Is car safe to drive: " + isSafe.ToString());


            Console.ReadKey();
        }
    }
}
