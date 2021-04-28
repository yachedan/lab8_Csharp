using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car{Name = "ModelName", Cost = 1250, Power = 50};
            var car2 = new Car{Name = "AnotherName", Cost = 1250, Power = 40};
            Console.WriteLine(car);
            Console.WriteLine(car2);
            Console.WriteLine(car.Compare(car,car2));
        }
    }
}
