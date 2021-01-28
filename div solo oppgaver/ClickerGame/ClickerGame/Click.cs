using System;
using System.Collections.Generic;
using System.Text;

namespace ClickerGame
{
    class Click:ICommand
    {
        private Game _game;
        public char Character { get; }= ' ';

        public Click(Game game)
        {
            _game = game;
        }
        
        public void Run()
        {
            _game.IncreasePoint();
        }
    }
}
