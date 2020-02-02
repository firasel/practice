using System;
using System.Collections.Generic;
using System.Text;

namespace Attribute
{
    public class Car
    {
        //attributes
        string _engine;
        int _wheel;
        int _seat;

        //method
        public void Start(int number)
        {
            if(number==1)
                Console.WriteLine($"start");
        }
        public void Open()
        { 
            Console.WriteLine($"Open door");
        }
        public void Close()
        {
            Console.WriteLine($"close door");
        }
        public void Lock()
        {
            Console.WriteLine($"door locked");
        }
        public void Run()
        {
            Console.WriteLine($"run");
        }
        public void Break()
        {
            Console.WriteLine($"car break");
        }
        public void Unlock()
        {
            Console.WriteLine($"door unlock");
        }

        //default constructor
        public Car(string engine,int wheel,int seat)
        {
            _engine = engine;
            _seat = seat;
            _wheel = wheel;
        }

    }
}
