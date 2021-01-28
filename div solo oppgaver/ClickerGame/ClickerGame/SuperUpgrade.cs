using System;
using System.Collections.Generic;
using System.Text;

namespace ClickerGame
{
    class SuperUpgrade : ICommand
    {
        private Game _game;
        public char Character { get; } = 's';

        public SuperUpgrade(Game game)
        {
            _game = game;
        }

        public void Run()
        {
            _game.IncreasePointsPerClickIncrease();
        }
    }
}
