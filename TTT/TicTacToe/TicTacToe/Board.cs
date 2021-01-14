using System;
using System.Threading;

namespace TicTacToe
{
    public class Board : Grid
    {
        public Tile[] Tiles;

        public Board(int height, int width, bool drawBorder = false)
        {
            Create(height, width);
            Tiles = new Tile[height * width];
            for (int i = 0; i < Tiles.Length; i++)
            {
                Vector position = Positions[i];
                bool isBorder = position.X == 0 || position.X == Width - 1 || position.Y == 0 || position.Y == Height - 1;
                Tiles[i] = new Tile(isBorder ? '#' : ' ');
            }
        }

        public Tile FetchTile(int x,int y)
        {
            int index = FetchIndex(x, y);
            return (index <= Tiles.Length && Tiles[index].Fill == ' ') ? Tiles[index] : null;
        }

        public bool CheckChars(char a, char b, char c)
        {
            return (a == b && a == c) ? true : false;
        }

        //public void CheckWin(char Char)
        //{
        //    if ((Char == Tiles[6].Fill && CheckChars(Tiles[6].Fill, Tiles[7].Fill, Tiles[8].Fill))
        //        || (Char == Tiles[11].Fill && CheckChars(Tiles[11].Fill, Tiles[12].Fill, Tiles[13].Fill))
        //        || (Char == Tiles[16].Fill && CheckChars(Tiles[16].Fill, Tiles[17].Fill, Tiles[18].Fill))
        //        ||
        //        ||
        //        ||
        //        ||

        //}

        public void Draw()
        {
            int count = 0;
            for(int i = 0; i < Tiles.Length; i++)
            {
                // Increase Width counter
                count++;
                // Draw tile
                Console.Write(Tiles[i].Fill);
                // Check counter
                if (count == Width)
                {
                    // Reset
                    Console.WriteLine();
                    count = 0;
                }
            }
        }
    }
}
