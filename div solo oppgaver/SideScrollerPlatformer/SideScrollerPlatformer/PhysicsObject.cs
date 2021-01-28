using System;
using System.Collections.Generic;
using System.Text;

namespace SideScrollerPlatformer
{
    public enum Direction {Right, Left, Up, Down};

    class PhysicsObject
    {
        public Vector Position;
        public bool IsFalling;
        private readonly char _character;
        public Grid Grid;
        public bool IsMoving = false;

        private static readonly Vector[] directions = new Vector[]
        {
            new Vector(1, 0),   // Right
            new Vector(-1,0),   // Left
            new Vector(0,-1),   // Up
            new Vector(0, 1),   // Down
        };

        public PhysicsObject(Vector position,char character, Grid grid)
        {
            Position = position;
            _character = character;
            Grid = grid;
        }

        public bool CheckNeighbour(Direction direction)
        {
            Vector neighbour = Position.Add(directions[(int) direction]);
            if (!Grid.WithinRange(neighbour)) return true;
            if (Grid.Fill[neighbour.X, neighbour.Y] != ' ') return true;
            return false;
        }

        public void Move(Vector direction)
        {
            Vector newPosition = Position.Add(direction);

            if (!Grid.WithinRange(newPosition.X, newPosition.Y)) return;
            // Clear current fill
            Grid.SetFillAtVector(Position, ' ');

            // Set new position
            Position = newPosition;

            // Set new fill
            Grid.SetFillAtVector(Position, _character);

            IsMoving = true;
        }

        public void Move(Direction direction)
        {
            Move(directions[(int) direction]);
        }
    }
}
