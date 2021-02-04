using System;
using System.Collections.Generic;
using System.Text;

namespace Controller
{
    class Percent
    {
        public int Percentile { get; private set; }

        public Percent()
        {
            Percentile = 0;
        }

        public void Set(int value)
        {
            if (value >= 0 && value <= 100) Percentile = value;
        }
    }
}
