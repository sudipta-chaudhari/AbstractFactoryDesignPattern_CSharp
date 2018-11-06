using System;

namespace AbstractFactoryPattern
{
    class Button : IControl
    {
        public void Display()
        {
            Console.WriteLine("Button displayed.");
        }
    }
}
