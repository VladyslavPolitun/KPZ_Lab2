using System;

namespace KPZ_Lab2.AbstractFactory
{
    public abstract class Device
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} | Brand: {Brand} | Model: {Model}");
        }
    }
}
