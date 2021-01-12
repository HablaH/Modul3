using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerVS
{
    class Player
    {
        private int _score;
        private readonly string _name;

        public Player(string name, int score)
        {
            _name = name;
            _score = score;
        }

        public void Play(Player opponent)
        {
            Console.WriteLine($"{_name} VS {opponent._name}!");
            int whoWins = Program.random.Next(2);
            if (whoWins < 1)
            {
                _score += 1;
                opponent._score += -1;
                Console.WriteLine($"{_name} Vant");
                Console.WriteLine(whoWins);
            }
            else
            {
                _score += -1;
                opponent._score += 1;
                Console.WriteLine($"{opponent._name} Vant");
                Console.WriteLine(whoWins);

            }
        }

        public void ShowNameAndPoints()
        {
            Console.WriteLine($"{_name} har {_score} poeng");
        }
    }
    
}
