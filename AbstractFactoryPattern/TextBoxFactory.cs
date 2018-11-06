namespace AbstractFactoryPattern
{
    class TextBoxFactory
    {
        internal static IControl GetTextBox(int textBoxType)
        {
            IControl objTextBox;

            switch(textBoxType)
            {
                case 1:
                    objTextBox = new TextBox();
                    break;
                case 2:
                    objTextBox = new RichTextBox();
                    break;
                default:
                    objTextBox = null;
                    break;
            }

            return objTextBox;
        }
    }
}
