using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SideScrollerPlatformer
{
    class Player:PhysicsObject
    {

        public Player(Vector position, Char character, Grid grid) : base(position ?? new Vector(0, 0), character, grid)
        {
            Move(new Vector(0,0));
        }

        //public void Move(Vector direction)
        //{
        //    Vector newPosition = Position.Add(direction);

        //    if (!_grid.WithinRange(newPosition.X, newPosition.Y)) return;
        //    // Clear current fill
        //    _grid.SetFillAtVector(Position, ' ');

        //    // Set new position
        //    Position = newPosition;

        //    // Set new fill
        //    _grid.SetFillAtVector(Position, _character);
        //}

    }
}
