using System.Collections.Generic;

namespace TVApp.Commands
{
    public sealed class MacroCommand : Command
    {
        List<Command> _commands =  new List<Command>();

        public MacroCommand(IEnumerable<Command> commands)
        {
            foreach (var command in commands)
                _commands.Add(command);
        }

        public override void Execute()
        {
            foreach (var command in _commands)
                command.Execute();
        }
    }
}
