using System;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop("hp elitebook 840 g3","8gb","1tb","core i3 4300U");
            Console.WriteLine(laptop.ToString());

            Mobile mobile = new Mobile("Samsung","4gb","32gb","snapdragon 665");
            Console.WriteLine(mobile.ToString());

            Computer computer = new Computer("hp probook","4gb","500gb","hp");
            Console.WriteLine(computer.ToString());

            Fashion fashion = new Fashion("t-shirt","L","500","red");
            Console.WriteLine(fashion.ToString());
        }
    }
}
