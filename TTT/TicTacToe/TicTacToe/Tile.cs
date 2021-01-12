using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Tile
    {
        public char fill;

        public Tile()
        {
            fill = '#';
        }

        public Tile(char fill)
        {
            this.fill = fill;
        }
    }
}
