using TVApp;
using TVApp.Commands;

public sealed class Enter5Command : Command
{
    readonly ViewBase _window;

    public Enter5Command(ViewBase window)
    {
        _window = window;
    }

    public override void Execute()
    {
        var activeElementCommands = _window.GetActiveUIElementCommands();

        activeElementCommands?.Enter5();
    }
}