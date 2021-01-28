using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SideScrollerPlatformer
{
    class InputManager
    {
        private ICommand[] _commands;
        private readonly Player _player;

        public InputManager(Player player)
        {
            _player = player;
            _commands = new ICommand[]
            {
                new MoveLeft(),
                new MoveRight(),
                new Jump()
            };
        }

        public void HandleInput(char input)
        {
            foreach (var command in _commands)
            {
                if(command.TryRun(input, _player)) return;
            }

        }
    }
}
