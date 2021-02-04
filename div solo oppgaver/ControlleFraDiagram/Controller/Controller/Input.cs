using System;
using System.Collections.Generic;
using System.Text;

namespace Controller
{
    abstract class Input
    {
        public String Name { get; }

        public Input(string name)
        {
            Name = name;
        }
        public abstract void  Use();
        public abstract string Output();
    };
}
    
