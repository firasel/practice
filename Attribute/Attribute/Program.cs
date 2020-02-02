using System;

namespace Attribute
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("toyta",4,5);
            Console.Write("start your car? enter:1");
            int i = int.Parse(Console.ReadLine());
            car.Start(i);
            car.Open();
            car.Close();
            car.Lock();
            car.Run();
        }
    }
}
