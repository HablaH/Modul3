using System;
using System.Collections.Generic;
using System.Text;

namespace Controller
{
    class Direction
    {
        public int Degree { get; private set; }

        public void Set(int value)
        {
            if (value >= 0 && value <= 360) Degree= value;
        }
    }
}
