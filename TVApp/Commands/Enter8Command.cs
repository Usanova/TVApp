using TVApp;
using TVApp.Commands;

public sealed class Enter8Command : Command
{
    readonly ViewBase _window;

    public Enter8Command(ViewBase window)
    {
        _window = window;
    }

    public override void Execute()
    {
        var activeElementCommands = _window.GetActiveUIElementCommands();

        activeElementCommands?.Enter8();
    }
}