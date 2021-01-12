using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        public static string command = "";
        static void Main(string[] args)
        {
            Board board = new Board(5, 5);
            while (true) 
            {
                board.Draw();
                command = Console.ReadLine();
                ReadCommand(command);
            }
        }

        public static void ReadCommand(string command)
        {
            Console.WriteLine(command);
            Console.Clear();
        }


    }
}
