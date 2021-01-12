using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Room[] map = new Room[]
            {
                new Room('A', "red"),
                new Room('B', "green"),
                new Room('C', "orange"),
                new Room('D', "blue"),
                new Room('E', "yellow"),
                new Room('F', null),
            };
            Player player1 = new Player(Console.ReadLine());
        }
    }
}
