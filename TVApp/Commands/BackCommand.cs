using System.Windows;

namespace TVApp.Commands
{
    public sealed class BackCommand : Command
    {
        readonly ViewBase _window;

        public BackCommand(ViewBase window)
        {
            _window = window;
        }

        public override void Execute()
        {
            if (_window.PreviousView == null)
                return;

            _window.Visibility = Visibility.Hidden;

            _window.PreviousView.ShowDialog();
        }
    }
}
