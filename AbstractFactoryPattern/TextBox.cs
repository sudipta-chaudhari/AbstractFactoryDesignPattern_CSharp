using System;

namespace AbstractFactoryPattern
{
    class TextBox : IControl
    {
        public void Display()
        {
            Console.WriteLine("TextBox displayed.");
        }
    }
}
