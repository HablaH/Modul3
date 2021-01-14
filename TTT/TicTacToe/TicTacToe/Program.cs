using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        
        public static Board board = new Board(5, 5);
        public static AI ai = new AI();
        static void Main(string[] args)
        {
            board.Draw();
            while (true)
            {
                ReadCommand(Console.ReadLine());
                ai.Move();
            }
        }

        public static void ReadCommand(string command)
        {
            string[] parameters = command.Split(',');
            Tile tile = board.FetchTile(int.Parse(parameters[0]), int.Parse(parameters[1]));

            if (tile != null)
            {
                tile.Fill = 'X';
                Console.Clear();
                board.Draw();
                Console.WriteLine(command);
            }
            else
            {
                Console.WriteLine("error; vector is out of range or position is filled");
                ReadCommand(Console.ReadLine());
            }
        }


    }
}
