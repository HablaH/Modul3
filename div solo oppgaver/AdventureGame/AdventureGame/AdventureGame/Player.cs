using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Player : Game
    {
        public Key[] inventory = new Key[5];
        public string name;

        public Player(string _name)
        {
            name = _name;
        }

        public void PickUp(Key key)
        {
            int indexOfEmpty = Array.IndexOf(inventory, null);
            Console.WriteLine($"Key = {key.GetKey().color}");
            inventory[indexOfEmpty] = key.GetKey();
        }

        public void UnlockDoor(Door door, Key key)
        {
            if(!currentRoom.ConnectedDoors(doors).Contains(door)) Console.WriteLine("That door isn't in this room");
            if (!inventory.Contains(key)) Console.WriteLine("You don't have the correct key");
            else door.Unlock(key);
        }

        public void Enter(Door door)
        {
            if (!currentRoom.ConnectedDoors(doors).Contains(door))
            {
                Console.WriteLine("That door isn't in this room");
                return;
            }

            if (currentRoom == door.connectedRooms[0]) currentRoom = door.connectedRooms[1];
            else currentRoom = door.connectedRooms[1];
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
