using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Grid
    {
        public int Height;
        public int Width;
        public Vector[] Positions;

        public void Create(int height, int width)
        {
            this.Height = height;
            this.Width = width;

            // Set vector position array size
            int arraySize = width * height;

            // Setup Positions array
            Positions = new Vector[arraySize];

            // Loop through X and Y axis to create grid Positions
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    // Fill position array element
                    int index = FetchIndex(x, y);
                    Positions[index] = new Vector(x, y);
                }
            }
        }

        public int FetchIndex(Vector position)
        {
            return position.X + (position.Y * Height);
        }
        public int FetchIndex(int x, int y)
        {
            return x + (y * Height);
        }
    }
}
