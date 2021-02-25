using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using RndGame;

namespace ConsoleGame
{
    class Player
    {
        private char Character;
        public Position pos;
        public Position oldPos;
        public int speed;
        public int size;

        public Player()
        {
            speed = 1;
            size = 1;
            Character = '0';
            pos = new Position(5, 5);
        }

        public void MoveLeft()
        {
            oldPos = pos;
            pos = new Position(oldPos.X - speed, oldPos.Y);
        }
        public void MoveRight()
        {
            oldPos = pos;
            pos = new Position(oldPos.X + speed, oldPos.Y);
        }
        public void MoveUp()
        {
            oldPos = pos;
            pos = new Position(oldPos.X, oldPos.Y - speed);
        }
        public void MoveDown()
        {
            oldPos = pos;
            pos = new Position(oldPos.X, oldPos.Y + speed);
        }


        public void Grow()
        {
            
        }

        public char GetPlayer()
        {
            return Character;
        }

        public void setPos()
        {
            Console.SetCursorPosition(pos.X, pos.Y);
        }

        public void HandleInput(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    MoveLeft();
                    break;
                case ConsoleKey.RightArrow:
                    MoveRight();
                    break;
                case ConsoleKey.UpArrow:
                    MoveUp();
                    break;
                case ConsoleKey.DownArrow:
                    MoveDown();
                    break;
            }
        }
    }
}