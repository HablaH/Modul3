using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TilfeldigeBoxer
{
    class VirtualScreen
    {
        private VirtualScreenRow[] _rows;

        public VirtualScreen(int width, int height)
        {
            _rows = new VirtualScreenRow[height];
            for (int i = 0; i < height; i++)
            {
                _rows[i] = new VirtualScreenRow(width);
            }
        }

        public void Add(Box box)
        {
            int middleLength = box.Height - 2;
            int middleStart = box.Y + 1;
            int lastY = box.Y + box.Height - 1;

            _rows[box.StartY].AddBoxTopRow(box.X, box.Width);
            for(int i = 0; i < middleLength; i++) 
            {
                _rows[middleStart + i].AddBoxMiddleRow(box.X, box.Width);
            }
            _rows[lastY].AddBoxBottomRow(box.X, box.Width);
        }

        public void Show()
        {
            foreach (var row in _rows)
            {
                row.Show();
            }
        }
    }
}
