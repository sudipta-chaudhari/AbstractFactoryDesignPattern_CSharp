using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter choice (1-2) for UI Element Type : ");
            Int16.TryParse(Console.ReadLine(), out short uiElementType);

            while (uiElementType != 1 && uiElementType != 2)
            {
                Console.Write("Please enter correct choice (1-2) for UI Element Type : ");
                Int16.TryParse(Console.ReadLine(), out uiElementType);
            }

            Console.Write("Enter choice (1-2) for Object Type : ");
            Int16.TryParse(Console.ReadLine(), out short objectType);

            while (objectType != 1 && objectType != 2)
            {
                Console.Write("Please enter correct (1 - 2) choice for UI Element Type : ");
                Int16.TryParse(Console.ReadLine(), out objectType);
            }

            IControl objUIElement = UIFactory.GetUIElement(uiElementType, objectType);

            Console.WriteLine();

            objUIElement.Display();

            Console.ReadKey();
        }
    }
}
