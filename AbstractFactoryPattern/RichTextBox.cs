using System;

namespace AbstractFactoryPattern
{
    class RichTextBox : IControl
    {
        public void Display()
        {
            Console.WriteLine("RichTextBox displayed.");
        }
    }
}
