using TVApp;
using TVApp.Commands;

public sealed class Enter6Command : Command
{
    readonly ViewBase _window;

    public Enter6Command(ViewBase window)
    {
        _window = window;
    }

    public override void Execute()
    {
        var activeElementCommands = _window.GetActiveUIElementCommands();

        activeElementCommands?.Enter6();
    }
}