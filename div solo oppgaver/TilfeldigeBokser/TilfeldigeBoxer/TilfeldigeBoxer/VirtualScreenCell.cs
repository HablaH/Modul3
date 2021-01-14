using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TilfeldigeBoxer
{
    class VirtualScreenCell
    {
        public bool Up { get; private set; }
        public bool Down { get; private set; }
        public bool Left { get; private set; }
        public bool Right { get; private set; }

        public VirtualScreenCell()
        {
            Up = false;
            Down = false;
            Left = false;
            Right = false;
        }
        public char GetCharacter()
        {
            char c = ' ';
            if (!Up && !Down && !Left && !Right) c = ' ';   //blank
            if (!Up && !Down && Left && Right)   c = '─';   //horisontal line
            if (Up && Down && !Left && !Right)   c = '│';   //vertical line
            if (!Up && Down && !Left && Right)   c = '┌';   //upper left corner
            if (!Up && Down && Left && !Right)   c = '┐';   //upper right corner
            if (Up && !Down && !Left && Right)   c = '└';   //lower left corner
            if (Up && !Down && Left && !Right)   c = '┘';   //lower right corner
            if (Up && Down && !Left && Right)    c = '├';   //no left
            if (Up && Down && Left && !Right)    c = '┤';   //no right
            if (!Up && Down && Left && Right)    c = '┬';   //no up
            if (Up && !Down && Left && Right)    c = '┴';   //no down
            if (Up && Down && Left && Right)     c = '┼';   //cross
            return c;
        }

        public void AddHorizontal()
        {
            Right = true;
            Left  = true;
        }

        public void AddVertical()
        {
            Up = true;
            Down = true;
        }

        public void AddLowerLeftCorner()
        {
            Up = true;
            Right = true;
        }

        public void AddUpperLeftCorner()
        {
            Down = true;
            Right = true;
        }

        public void AddUpperRightCorner()
        {
            Down = true;
            Left = true;
        }

        public void AddLowerRightCorner()
        {
            Up = true;
            Left = true;
        }
    }
}
