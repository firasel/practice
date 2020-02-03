using System;
using System.Collections.Generic;
using System.Text;

namespace Attribute
{
    public class Vehicle
    {
        public string _engine;
        public int _wheel;
        public int _seat;

        public void Start()
        {
            Console.WriteLine("start");
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
            Console.WriteLine($"break");
        }
        public void Unlock()
        {
            Console.WriteLine($"door unlock");
        }
    }
}
