using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TicTacToe
{
    class AI
    {
        private Random random = new Random();

        public void Move()
        {
            Tile tile = null;
            if (Program.board.Tiles.Any(t => t.Fill == ' ')) 
            {  
                while (tile == null) 
                { 
                    int x = random.Next(1, 4);
                    int y = random.Next(1, 4);
                    tile = Program.board.FetchTile(x,y);
                }
                Thread.Sleep(2000);
                tile.Fill = 'O';
                Console.Clear();
                Program.board.Draw();
            }
            else Console.WriteLine("Game over");
        }
    }
}
