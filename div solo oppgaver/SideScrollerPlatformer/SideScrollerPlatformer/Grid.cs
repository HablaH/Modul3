using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SideScrollerPlatformer
{
    class Grid
    {
        public char[,] Fill;
        public bool HasBeenAltered;
        private int _heigth, _width;

        public Grid(int width, int height)
        {
            _heigth = height;
            _width = width;

            HasBeenAltered = true;

            Fill = new char[width, height];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Fill[x, y] = ' ';
                }
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder(); 
            for (int y = 0; y < Fill.GetLength(1); y++)
            {
                for (int x = 0; x < Fill.GetLength(0); x++)
                {
                    str.Append(Fill[x, y]);
                }

                str.Append("\n");
            }

            return str.ToString();
        }

        public bool SetFillAtVector(int x, int y, char fill = '#')
        {
            if (!WithinRange(x, y)) return false;
            Fill[x,y] = fill;
            HasBeenAltered = true;
            return true;
        }

        public bool SetFillAtVector(Vector position, char fill)
        {
            return SetFillAtVector(position.X, position.Y, fill);
        }

        public void FillHorizontal(int y,char fill = '#')
        {
            if (!WithinRange(0, y)) return;
            for (int x = 0; x < _width-1; x++)
            {
                SetFillAtVector(x, y, fill);
            }
        }
        public void FillVertical(int x,char fill = '#')
        {
            if (!WithinRange(x, 0)) return;
            for (int y = 0; y < _heigth-1; y++)
            {
                SetFillAtVector(x, y, fill);
            }
        }

        public bool WithinRange(int positionX, int positionY) 
        {
            bool xValid = (positionX >= 0 && positionX <= _width - 1);
            bool yValid = (positionY >= 0 && positionY <= _heigth - 1);
            return xValid && yValid;
        }

        public bool WithinRange(Vector position)
        {
            return WithinRange(position.X, position.Y);
        }
    }
}
