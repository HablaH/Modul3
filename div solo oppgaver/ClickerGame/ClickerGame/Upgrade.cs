using System;
using System.Collections.Generic;
using System.Text;

namespace ClickerGame
{
    class Upgrade : ICommand
    {
        private Game _game;
        public char Character { get; } = 'u';

        public Upgrade(Game game)
        {
            _game = game;
        }

        public void Run()
        {
            _game.IncreasePointsPerClick();
        }
    }
}
