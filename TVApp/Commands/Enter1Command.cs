namespace TVApp.Commands
{
    public sealed class Enter1Command : Command
    {
        readonly ViewBase _window;

        public Enter1Command(ViewBase window)
        {
            _window = window;
        }

        public override void Execute()
        {
            var activeElementCommands = _window.GetActiveUIElementCommands();

            activeElementCommands?.Enter1();
        }
    }
}
