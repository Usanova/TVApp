namespace TVApp.Commands
{
    public sealed class LeftCommand : Command
    {
        readonly ViewBase _window;

        public LeftCommand(ViewBase window)
        {
            _window = window;
        }

        public override void Execute()
        {
            var activeElementCommands = _window.GetActiveUIElementCommands();

            activeElementCommands?.EnterLeft();
        }
    }
}
