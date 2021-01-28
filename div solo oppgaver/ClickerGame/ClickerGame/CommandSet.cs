using System;
using System.Collections.Generic;
using System.Text;

namespace ClickerGame
{
    class CommandSet
    {
        private ICommand[] _commands;

        public CommandSet(Game game)
        {
            _commands = new ICommand[]
            {
                new Exit(),
                new Click(game),
                new Upgrade(game),
                new SuperUpgrade(game)
            };
        }

        public void Run(char commandChar)
        {
            var command = FindCommand(commandChar);
            command?.Run();
        }

        private ICommand FindCommand(char commandChar)
        {
            foreach (var command in _commands)
            {
                if (command.Character == commandChar) return command;
            }

            return null;
        }
    }
}
