using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Door
    {
        public bool locked = true;
        public string color;
        public Char[] connectedRooms;

        public Door(string color)
        {
            this.color = color;
            FromTo(color);
        }

            public void Unlock(Key key)
        {
            if (key.color == color)
            {
                locked = false;
            }
        }

            public void FromTo(string color)
            {
                if (color == "red") connectedRooms = new char[] {'A', 'B'};
                if (color == "green") connectedRooms = new char[] {'A', 'D'};
                if (color == "yellow") connectedRooms = new char[] {'B', 'C'};
                if (color == "blue") connectedRooms = new char[] {'B', 'E'};
                if (color == "orange") connectedRooms = new char[] {'E', 'F'};
            }
    }
}
