using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Map
    {
        public Room A;
        public Room B;
        public Room C;
        public Room D;
        public Room E;
        public Room F;
        public Door RedDoor;
        public Door GreenDoor;
        public Door OrangeDoor;
        public Door BlueDoor;
        public Door YellowDoor;

        public Map()
        {

            A = new Room('A', "red");
            B = new Room('B', "green");
            C = new Room('C', "orange");
            D = new Room('D', "blue");
            E = new Room('E', "yellow");
            F = new Room('F', null);
            RedDoor = new Door("red");
            GreenDoor = new Door("green");
            OrangeDoor = new Door("orange");
            BlueDoor = new Door("blue");
            YellowDoor = new Door("yellow");
        }
    }
}
