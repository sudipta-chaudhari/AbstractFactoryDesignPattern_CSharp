namespace AbstractFactoryPattern
{
    public abstract class UIFactory
    {
        internal static IControl GetUIElement(int uiElementType, int objectType)
        {
            IControl objUIElement;

            switch(uiElementType)
            {
                case 1:
                    objUIElement = ButtonFactory.GetButton(objectType);
                    break;
                case 2:
                    objUIElement = TextBoxFactory.GetTextBox(objectType);
                    break;
                default:
                    objUIElement = null;
                    break;
            }

            return objUIElement;
        }
    }
}
