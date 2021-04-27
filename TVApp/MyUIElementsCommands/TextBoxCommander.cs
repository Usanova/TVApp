using System.Windows.Controls;
using TVApp.Commands.CommandsForUIElements;

namespace TVApp.MyUIElementsCommands
{
    public sealed class TextBoxCommander : UIElementCommanderBase
    {
        TextBox _textBox;

        public TextBoxCommander(TextBox textBox)
        {
            _textBox = textBox;

            Enter0Command = new EnterToTextBoxCommand(textBox, 0);
            Enter1Command = new EnterToTextBoxCommand(textBox, 1);
            Enter2Command = new EnterToTextBoxCommand(textBox, 2);
            Enter3Command = new EnterToTextBoxCommand(textBox, 3);
            Enter4Command = new EnterToTextBoxCommand(textBox, 4);
            Enter5Command = new EnterToTextBoxCommand(textBox, 5);
            Enter6Command = new EnterToTextBoxCommand(textBox, 6);
            Enter7Command = new EnterToTextBoxCommand(textBox, 7);
            Enter8Command = new EnterToTextBoxCommand(textBox, 8);
            Enter9Command = new EnterToTextBoxCommand(textBox, 9);
            EnterLeftCommand = new EraseFromTextBoxCommand(textBox);
        }

        public override void Focus() =>_textBox.Focus();
    }
}
