using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TilfeldigeBoxer
{
    class VirtualScreenRow
    {
        private VirtualScreenCell[] _cells;

        public VirtualScreenRow(int screenWidth)
        {
            _cells = new VirtualScreenCell[screenWidth];
            for (int i = 0; i <screenWidth; i++)
            {
                _cells[i] = new VirtualScreenCell();
            }
        }

        public void AddBoxTopRow(int boxX, int boxWidth)
        {
            int lineLength = boxWidth - 2;              
            int lineStart = boxX + 1;
            int lastX = boxX + boxWidth - 1;

            _cells[boxX].AddUpperLeftCorner();

            for (int i = 0; i < lineLength; i++)
            {
                _cells[lineStart + i].AddHorizontal();
            }

            _cells[lastX].AddUpperRightCorner();
        }

        public void AddBoxBottomRow(int boxX, int boxWidth)
        {
            int lineLength = boxWidth - 2;
            int lineStart = boxX + 1;
            int lastX = boxX + boxWidth - 1;

            _cells[boxX].AddLowerLeftCorner();

            for (int i = 0; i < lineLength; i++)
            {
                _cells[lineStart + i].AddHorizontal();
            }

            _cells[lastX].AddLowerRightCorner();
        }

        public void AddBoxMiddleRow(int boxX, int boxWidth)
        {
            int lastX = boxX + boxWidth - 1;

            _cells[boxX].AddVertical();
            _cells[lastX].AddVertical();
        }

        public void Show()
        {
            foreach (var cell in _cells)
            {
                Console.Write(cell.GetCharacter());
            }
            Console.WriteLine();
        }
    }
}
