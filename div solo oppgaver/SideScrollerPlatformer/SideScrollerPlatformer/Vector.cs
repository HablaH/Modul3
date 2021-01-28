using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SideScrollerPlatformer
{
    class Vector
    {
        public int X, Y;

        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Vector Add(Vector other)
        {
            return new Vector(X + other.X, Y + other.Y);
        }

        public bool CompareTo(Vector other) 
        {
            return (X == other.X && Y == other.Y);
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}
