using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Grid
    {
        public int height;
        public int width;
        public Vector[] positions;

        public void Create(int height, int width)
        {
            this.height = height;
            this.width = width;

            // Set vector position array size
            int arraySize = width * height;

            // Setup positions array
            positions = new Vector[arraySize];

            // Loop through x and y axis to create grid positions
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    // Fill position array element
                    int index = FetchIndex(x, y);
                    positions[index] = new Vector(x, y);
                }
            }
        }

        public int FetchIndex(Vector position)
        {
            return position.x + (position.y * height);
        }
        public int FetchIndex(int x, int y)
        {
            return x + (y * height);
        }
    }
}
