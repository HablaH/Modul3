using System;
using System.Collections.Generic;
using System.Text;

namespace Controller
{
    class Button:Input
    {
        //public string Name { get; }
        public bool IsPressed { get; private set; }

        public Button(string name):base(name)
        {
            //Name = name;
        }
        public override void Use()
        {
            IsPressed = !IsPressed;
        }

        public override string Output()
        {
            return IsPressed ? $"{Name} is pressed down" : $"{Name} is not pressed down";
        }
    }
}
