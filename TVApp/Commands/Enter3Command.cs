namespace TVApp.Commands
{
    public sealed class Enter3Command : Command
    {
        readonly ViewBase _window;

        public Enter3Command(ViewBase window)
        {
            _window = window;
        }

        public override void Execute()
        {
            var activeElementCommands = _window.GetActiveUIElementCommands();

            activeElementCommands?.Enter3();
        }
    }
}
