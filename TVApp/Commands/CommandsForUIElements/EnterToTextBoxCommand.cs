using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TVApp.Commands.CommandsForUIElements
{
    public sealed class EnterToTextBoxCommand : Command
    {
        TextBox _textBox;
        readonly int _key;

        public EnterToTextBoxCommand(TextBox textBox, int key)
        {
            _textBox = textBox;
            _key = key;
        }

        public override void Execute()
        {
            _textBox.Text += _key;
        }
    }
}
