using System.Windows.Controls;

namespace TVApp.Commands.CommandsForUIElements
{
    public sealed class CheckEmailAndPasswordCommand : Command
    {
        TextBox _emailTextBox;

        TextBox _passwordTextBox;

        public CheckEmailAndPasswordCommand(TextBox emailTextBox, TextBox passwordTextBox)
        {
            _emailTextBox = emailTextBox;
            _passwordTextBox = passwordTextBox;
        }

        public Command SuccessfulCheck { get; set; }

        public Command UnsuccessfulCheck { get; set; }

        public override void Execute()
        {
            if (_emailTextBox.Text == "0" && _passwordTextBox.Text == "1")
                SuccessfulCheck?.Execute();
            else
                UnsuccessfulCheck?.Execute();
        }
    }
}
