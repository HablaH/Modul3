using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Key
    {
        public string color;

        public Key(string color)
        {
            this.color = color;
        }

        public string KeyColor()
        {
            return color;
        }

        public Key GetKey()
        {
            return this;
        }

    }
}
