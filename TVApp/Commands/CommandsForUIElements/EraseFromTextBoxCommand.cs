using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TVApp.Commands.CommandsForUIElements
{
    public sealed class EraseFromTextBoxCommand : Command
    {
        TextBox _textBox;

        public EraseFromTextBoxCommand(TextBox textBox)
        {
            _textBox = textBox;
        }

        public override void Execute()
        {

            if (string.IsNullOrEmpty(_textBox.Text))
                return;

            _textBox.Text = _textBox.Text.Substring(0, _textBox.Text.Length - 1);
        }
    }
}
