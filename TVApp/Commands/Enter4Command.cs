using TVApp;
using TVApp.Commands;

public sealed class Enter4Command : Command
{
    readonly ViewBase _window;

    public Enter4Command(ViewBase window)
    {
        _window = window;
    }

    public override void Execute()
    {
        var activeElementCommands = _window.GetActiveUIElementCommands();

        activeElementCommands?.Enter4();
    }
}