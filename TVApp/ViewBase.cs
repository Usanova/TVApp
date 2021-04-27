using DevExpress.Mvvm;
using System.Windows;
using TVApp.Commands;
using TVApp.MyUIElementsCommands;

namespace TVApp
{
    public class ViewBase : Window
    {
        public ViewBase PreviousView;
        protected Сommander _commander;

        public string CommandName { get; set; }

        public ViewBase(ViewBase previousView = null)
        {
            PreviousView = previousView;
            _commander = new Сommander();
        }

        public DelegateCommand ExecuteCommand => new DelegateCommand(() =>
        {
            try
            {
                _commander.InvokeCommand(CommandName);
            }
            catch(InvalidCommandNameException e)
            {
            }
        });

        private void SendCommand(object sender, RoutedEventArgs e)
        {
            _commander.InvokeCommand(CommandName);
        }

        protected UIElementCommanderBase[] _rowUIElementCommands;
        protected int _activeElementIndex = -1;

        public UIElementCommanderBase GetActiveUIElementCommands() 
            => _activeElementIndex == -1 ? null : _rowUIElementCommands[_activeElementIndex];

        public void Down()
        {
            if (_activeElementIndex == _rowUIElementCommands.Length - 1)
                _activeElementIndex = 0;
            else
                _activeElementIndex++;

            _rowUIElementCommands[_activeElementIndex].Focus();
        }

        public void Up()
        {
            if(_activeElementIndex <= 0)
                _activeElementIndex = _rowUIElementCommands.Length - 1;
            else
                _activeElementIndex--;

            _rowUIElementCommands[_activeElementIndex].Focus();
        }
    }
}
