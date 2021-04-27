namespace TVApp.Commands
{
    public sealed class DownCommand : Command
    {
        ViewBase _window;

        public DownCommand(ViewBase window)
        {
            _window = window;
        }

        public override void Execute()
        {
            _window.Down();
        }
    }
}
