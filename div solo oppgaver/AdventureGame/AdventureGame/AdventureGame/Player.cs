using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Player 
    {
        public Key[] inventory = new Key[5];
        public string name;
        public Room currentRoom;

        public Player(string _name)
        {
            name = _name;
        }

        public void PickUp(Key key)
        {
            int indexOfEmpty = Array.IndexOf(inventory, null);

            inventory[indexOfEmpty] = key.GetKey();
        }

        public void UnlockDoor(Door door, Key key)
        {
            if(!currentRoom.ConnectedDoors().Contains(door)) Console.WriteLine("That door isn't in this room");
            if (!inventory.Contains(key)) Console.WriteLine("You don't have the correct key");
            else door.Unlock(key);
        }

        public void Enter(Door door)
        {
            if (!currentRoom.ConnectedDoors().Contains(door))
            {
                Console.WriteLine("That door isn't in this room");
                return;
            }

            currentRoom = currentRoom == door.connectedRooms[0] ? door.connectedRooms[1] : door.connectedRooms[0];
            Console.WriteLine("you entered");
        }


        public string ShowInventory()
        {
            string str = String.Empty;
            foreach (Key key in inventory)
            {
                if(key != null) str += key.KeyColor() + " key";
            }
            return str;
        }
    }
}
