using System;

namespace CarObjects
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var car = new Car("Volvo");
            Console.WriteLine("Brand: " + car.Brand);
            Console.WriteLine("Default speed: " + car.Speed);
            car.Accelerate(20);
            car.Accelerate(10);
            Console.WriteLine("New speed: " + car.Speed);
            car.Brake();
            Console.WriteLine("Speed after braking: " + car.Speed);
            Console.WriteLine(car);
           
            Car car2 = new Car();
            Console.WriteLine("Brand: " + car2.Brand);
            Console.WriteLine("Default speed: " + car2.Speed);

            var car3 = new Car("Audi",100);
            Console.WriteLine(car3);
            Console.ReadKey();
        }
    }
}
