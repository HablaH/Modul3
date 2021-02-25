using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ConsoleGame;

namespace RndGame
{
    class Screen
    {
        public int width;
        public int height;

        private Player player;

        public Screen()
        {
            width = 200;
            height = 70;

            player = new Player();

            SetConsoleSize();
            
        }

        public void Update()
        {
            player.HandleInput(Console.ReadKey().Key);
            Console.SetCursorPosition(player.oldPos.X, player.oldPos.Y);
            Console.Write(" ");
            Console.SetCursorPosition(player.pos.X, player.pos.Y);
            Console.Write(player.GetPlayer());
        }



        public void SetConsoleSize()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetWindowSize(width,height);
        }
    }
}
