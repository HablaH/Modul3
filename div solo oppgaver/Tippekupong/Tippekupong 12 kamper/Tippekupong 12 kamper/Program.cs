using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tippekupong_12_kamper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nSkriv inn dine 12 tips med komma mellom: ");
            var bets = Console.ReadLine();
            var twelveMatches = new TwelveMatches(bets);



            while (true)
            {
                Console.Write("Skriv kampnr. 1-12 for scoring eller X for alle kampene er ferdige\r\nAngi kommando: ");
                var command = Console.ReadLine();
                if (command == "X") break;
                else twelveMatches.SelectMatch(command);

                var team = Console.ReadLine();
                twelveMatches.AddGoal(team == "H");

                twelveMatches.GetScore();
            }
        }
    }
}
