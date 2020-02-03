using System;

namespace Attribute
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car Object
            Car car = new Car();
            car._engine = "toyta";
            car._seat = 5;
            car._wheel = 4;
            car.Start();
            car.Open();
            car.Close();
            car.Lock();
            car.Run();
            //Bus object
            Bus bus = new Bus();
            bus._engine = "Bmw";
            bus._seat = 50;
            bus._wheel = 6;
            bus.Start();
            bus.Open();
            bus.Close();
            bus.Lock();
            bus.Run();
            //Product Object
            Product product = new Product();
           

            //Shopping Cart Object
            Shopping_cart shopping = new Shopping_cart();
            shopping._quantity = 5;



        }
    }
}
