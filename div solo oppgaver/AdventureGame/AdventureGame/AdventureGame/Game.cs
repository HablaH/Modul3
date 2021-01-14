using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Game
    {
        public Room[] map;
        public static Door[] doors;
        public Player player;
        
        private bool victory = false;


        public Game()
        {
            SetUpGame();
            
            Console.WriteLine(player.name);
            Intro();


            while (!victory)
            {
                HandleCommand(Console.ReadLine());
                ShowRoom();
            }



            //HandleCommand(player1, Console.ReadLine());
            //Console.WriteLine($"{player1.name} has {player1.ShowInventory()}");
            //Console.WriteLine($"on the floor you see {player1.currentRoom.key}");
        }

        public void HandleCommand(string command)
        {
            Console.Clear();
            switch (command)
            {
                case "pick up key":
                    player.PickUp(player.currentRoom.key);
                    player.currentRoom.key = null;
                    break;
                case "unlock red door":
                    player.UnlockDoor(doors[0], player.inventory[0]);
                    break;
                case "unlock green door":
                    player.UnlockDoor(doors[1], player.inventory[1]);
                    break;
                case "unlock blue door":
                    player.UnlockDoor(doors[3], player.inventory[2]);
                    break;
                case "unlock yellow door":
                    player.UnlockDoor(doors[2], player.inventory[3]);
                    break;
                case "unlock black door":
                    player.UnlockDoor(doors[4], player.inventory[4]);
                    break;
                case "enter red door":
                    player.Enter(doors[0]);
                    break;
                case "enter green door":
                    player.Enter(doors[1]);
                    break;
                case "enter yellow door":
                    player.Enter(doors[2]);
                    break;
                case "enter blue door":
                    player.Enter(doors[3]);
                    break;
                case "enter black door":
                    player.Enter(doors[4]);
                    Outro();
                    break;
                case "inventory":
                    Console.WriteLine(player.ShowInventory());
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("wrong command");
                    break;
            }
        }

        Room[] CreateMap()
        {
            return new Room[]
            {
                new Room('A', "red"),
                new Room('B', "green"),
                new Room('C', "black"),
                new Room('D', "blue"),
                new Room('E', "yellow"),
                new Room('F', null),
            };
        }

        Door[] CreateDoors(Room[] map)
        {
            return new Door[]
            {
                new Door("red", map),
                new Door("green", map),
                new Door("yellow", map),
                new Door("blue", map),
                new Door("black", map),
            };
        }

        void Intro()
        {
            Console.WriteLine($"Welcome, {player.name}.");
            Console.WriteLine("You awaken and find yourself in a dark room");
            ShowRoom();
        }

        void ShowRoom()
        {
            Key key = player.currentRoom.key;
            Door[] currentDoors = player.currentRoom.ConnectedDoors();
            string keyText = key != null ? $"On the floor you see a {key.KeyColor()} key." : "There is nothing here..";
            string isAre = currentDoors.Length == 1 ? "is" : "are";
            string doorDoors = currentDoors.Length == 1 ? "door" : "doors";


            Console.WriteLine(keyText);
            Console.WriteLine($"There {isAre} {currentDoors.Length} {doorDoors} leading out of the room.");
            foreach (Door door in currentDoors)
            {
                string lockedDoor = door.locked ? "locked" : "unlocked";
                Console.WriteLine($"One door is {door.color}, it is {lockedDoor} ");
            }
        }

        //void AvailableActions()
        //{
        //    string[] availableOptions;
        //    Door[] currentDoors = currentRoom.ConnectedDoors(doors);
        //    bool keyAvailable = currentRoom.key != null;
        //    int actions = (keyAvailable ? 1 : 0) + currentDoors.Length;
        //    int doorIndex = 0;
        //    availableOptions = new string[actions];
        //    foreach (var door in currentDoors)
        //    {
                

        //        doorIndex++;
        //    }
        //}

        void SetUpGame()
        {
            map = CreateMap();
            doors = CreateDoors(map);
            Console.WriteLine("Enter player name:");
            player = new Player(Console.ReadLine());
            player.currentRoom = map[0];
        }

        void Outro()
        {
            Console.WriteLine("You finally see the light.");
            Console.WriteLine("From this room you can finally get out!");
            Console.WriteLine("Ctrl + C");
            Console.ReadLine();
            
        }
    }
}
