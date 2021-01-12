using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Player
    {
        public Room currentPosition;
        public Key[] inventory = new Key[5];
        public string name;

        public Player(string _name)
        {
            name = _name;
        }

        public void PickUp()
        {
            foreach (Key key in inventory)
            {
                if (key == null)
                {
                    inventory[Array.IndexOf(inventory, key)] = currentPosition.key;
                    currentPosition.key = null;
                }
            }
        }

        public void UnlockDoor(Door door, Key key)
        {
            if (inventory.Any())
        }

        public void MoveTo(char room)
        {
            currentPosition = 
        }

        public void EnterDoor(Door door)
        {
            if (currentPosition.roomName == door.connectedRooms[0]) 
        }
    }
}
