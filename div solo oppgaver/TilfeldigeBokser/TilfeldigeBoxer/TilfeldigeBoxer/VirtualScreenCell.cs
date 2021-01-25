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
            //if (!Up && !Down && Left && Right) return '─';   //horisontal line
            //if (Up && Down && !Left && !Right) return '│';   //vertical line
            //if (!Up && Down && !Left && Right) return '┌';   //upper left corner
            //if (!Up && Down && Left && !Right) return '┐';   //upper right corner
            //if (Up && !Down && !Left && Right) return '└';   //lower left corner
            //if (Up && !Down && Left && !Right) return '┘';   //lower right corner
            //if (Up && Down && !Left && Right) return '├';   //no left
            //if (Up && Down && Left && !Right) return '┤';   //no right
            //if (!Up && Down && Left && Right) return '┬';   //no up
            //if (Up && !Down && Left && Right) return '┴';   //no down
            //if (Up && Down && Left && Right) return '┼';   //cross
            //return ' ';                                        //blank

            char[] chars = {' ', '\0', '\0', '─', '\0', '┌', '┐', '┬', '\0', '└', '┘', '┴', '│', '├', '┤', '┼'};
            var boolByte = 0;
            boolByte ^= Right ? 1 << 0 : 0;
            boolByte ^= Left ? 1 << 1 : 0;
            boolByte ^= Down ? 1 << 2 : 0;
            boolByte ^= Up ? 1 << 3 : 0;
            return chars[boolByte];

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
