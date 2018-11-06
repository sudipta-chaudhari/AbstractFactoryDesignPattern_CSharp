using System;

namespace AbstractFactoryPattern
{
    class RadioButton : IControl
    {
        public void Display()
        {
            Console.WriteLine("Radio Button displayed.");
        }
    }
}
