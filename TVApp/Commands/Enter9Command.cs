using TVApp;
using TVApp.Commands;

public sealed class Enter9Command : Command
{
    readonly ViewBase _window;

    public Enter9Command(ViewBase window)
    {
        _window = window;
    }

    public override void Execute()
    {
        var activeElementCommands = _window.GetActiveUIElementCommands();

        activeElementCommands?.Enter9();
    }
}