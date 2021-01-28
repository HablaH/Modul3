using System;
using System.Collections.Generic;
using System.Text;

namespace ClickerGame
{
    class Game
    {
        public int Points { get; private set; } = 0;
        private int _pointsPerClick = 1;
        private int _pointsPerClickIncrease = 1;
        

        public void IncreasePoint()
        {
            Points += _pointsPerClick;
        }

        public void IncreasePointsPerClick()
        {
            if (Points < 10) return;
            _pointsPerClick += _pointsPerClickIncrease;
            Points -= 10;
        }

        public void IncreasePointsPerClickIncrease()
        {
            if (Points < 100) return;
            _pointsPerClickIncrease++;
            Points -= 100;
        }
    }
    
}