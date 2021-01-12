using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Board : Grid
    {
        public Tile[] tiles;

        public Board(int height, int width, bool drawBorder = false)
        {
            Create(height, width);
            tiles = new Tile[height * width];
        }

        public void Draw()
        {
            int count = 0;
            for(int i = 0; i < tiles.Length; i++)
            {
                // Increase width counter
                count++;

                Vector position = positions[i];

                // Tile border check
                bool isBorder = position.x == 0 || position.x == width - 1 || position.y == 0 || position.y == height - 1;

                // Create tile
                tiles[i] = new Tile(isBorder ? '#' : ' ');

                // Draw tile
                Console.Write(tiles[i].fill);
                //Console.Write(positions[i].ToString());

                // Check counter
                if (count == width)
                {
                    // Reset
                    Console.WriteLine();
                    count = 0;
                }
            }
        }
    }
}
