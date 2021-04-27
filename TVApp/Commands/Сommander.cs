using System;
using System.Collections.Generic;

namespace TVApp.Commands
{
    public sealed class Сommander
    {
        Dictionary<string, Command> Commands;

        public Сommander()
        {
            Commands = new Dictionary<string, Command>();
        }

        public void RegisteredCommad(string commandName, Command command)
        {
            Commands[commandName] = command;
        }

        public void RegisteredCommad(string[] commandNames, Command command)
        {
            foreach(var commandName in commandNames)
                Commands[commandName] = command;
        }

        public void InvokeCommand(string commandName)
        {
            if (commandName == null || !Commands.ContainsKey(commandName))
                throw new InvalidCommandNameException(commandName);

            Commands[commandName].Execute();
        }
    }

    public sealed class InvalidCommandNameException : Exception
    {
        public InvalidCommandNameException(string commandName) : base($"Command with name {commandName} not found")
        { }
    }
}
