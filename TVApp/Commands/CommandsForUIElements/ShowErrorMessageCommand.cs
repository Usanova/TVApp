using System.Windows;

namespace TVApp.Commands.CommandsForUIElements
{
    public sealed class ShowErrorMessageCommand : Command
    {
        string _errorMessage;

        public ShowErrorMessageCommand(string errorMessage)
        {
            _errorMessage = errorMessage;
        }

        public override void Execute()
        {
            MessageBox.Show(_errorMessage, "", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
