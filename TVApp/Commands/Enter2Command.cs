namespace TVApp.Commands
{
    public sealed class Enter2Command : Command
    {
        readonly ViewBase _window;

        public Enter2Command(ViewBase window)
        {
            _window = window;
        }

        public override void Execute()
        {
            var activeElementCommands = _window.GetActiveUIElementCommands();

            activeElementCommands?.Enter2();
        }
    }
}
