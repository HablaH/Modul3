using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tippekupong_12_kamper
{
    class TwelveMatches
    {
        private readonly string[] _bets;
        private Match[] _matches = new Match[12];
        private Match _selectedMatch;
        private int _correctCount = 0;
        private int _matchNo;

        public TwelveMatches(string betsText)
        {
            _bets = betsText.Split(',');
            
            for (var i = 0; i < 12; i++)
            {
                _matches[i] = new Match(_bets[i]);
            }
        }

        public void SelectMatch(string command)
        {
            _matchNo = Convert.ToInt32(command);
            Console.Write($"Scoring i kamp {_matchNo}. \r\nSkriv H for hjemmelag eller B for bortelag: ");            
            var selectedIndex = _matchNo - 1;
            _selectedMatch = _matches[selectedIndex];
        }

        public void AddGoal(bool isHomeTeam)
        {
            _selectedMatch.AddGoal(isHomeTeam);
        }

        public void GetScore()
        {
            for (var index = 0; index < _matches.Length; index++)
            {
                var match = _matches[index];
                _matchNo = index + 1;
                var isBetCorrect = match.IsBetCorrect();
                var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
                if (isBetCorrect) _correctCount++;
                Console.WriteLine($"Kamp {_matchNo}: {match.GetScore()} - {isBetCorrectText}");
            }

            Console.WriteLine($"Du har {_correctCount} rette.");
        }
    }
}
