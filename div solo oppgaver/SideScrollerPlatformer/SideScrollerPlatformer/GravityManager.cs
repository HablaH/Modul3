using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SideScrollerPlatformer
{
    class GravityManager
    {
        private readonly Grid _grid;
        private List<PhysicsObject> _physicsObjects;

        public GravityManager(Grid grid, params PhysicsObject[] parameters)
        {
            _grid = grid;
            _physicsObjects = parameters.ToList();
        }

        public void IsFalling()
        {
            foreach (var obj in _physicsObjects)
            {
                obj.IsFalling = !obj.CheckNeighbour(Direction.Down);
                if (obj.IsFalling) _grid.HasBeenAltered = true;
            }
        }

        public void Fall()
        {
            foreach (var obj in _physicsObjects)
            {
                if (obj.IsFalling) obj.Move(Direction.Down);
            }
        }
    }
}
