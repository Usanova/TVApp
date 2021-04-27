using TVApp;
using TVApp.Commands;

public sealed class Enter7Command : Command
{
    readonly ViewBase _window;

    public Enter7Command(ViewBase window)
    {
        _window = window;
    }

    public override void Execute()
    {
        var activeElementCommands = _window.GetActiveUIElementCommands();

        activeElementCommands?.Enter7();
    }
}