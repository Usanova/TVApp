namespace TVApp.Commands
{
    public sealed class Enter0Command : Command
    {
        readonly ViewBase _window;

        public Enter0Command(ViewBase window)
        {
            _window = window;
        }

        public override void Execute()
        {
            var activeElementCommands = _window.GetActiveUIElementCommands();

            activeElementCommands?.Enter0();
        }
    }
}
