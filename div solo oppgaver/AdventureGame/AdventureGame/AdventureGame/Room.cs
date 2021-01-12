using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Room
    {
        public Key key;
        public char roomName;

        public Room(char roomName, string key)
        {
            this.roomName = roomName;
            this.key = new Key(key);
        }
    }
}
