using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;

namespace Controller
{
    class DPad:Input
    {
        //public string Name { get; }
        public Button[] buttons;
        public Direction direction;
        
        public DPad(string name):base(name)
        {
            //Name = name;
            buttons = new Button[] { 
                new Button(name + "Up"),
                new Button(name + "Right"),
                new Button(name + "Down"),
                new Button(name + "Left"),
            };
            direction = new Direction();
        }

        public override void Use()
        {
            
        }
        
        public void Use(int dir)
        {
            if (dir == 0 && buttons[2].IsPressed == false) buttons[dir].Use();
            if (dir == 1 && buttons[3].IsPressed == false) buttons[dir].Use();
            if (dir == 2 && buttons[0].IsPressed == false) buttons[dir].Use();
            if (dir == 3 && buttons[1].IsPressed == false) buttons[dir].Use();
            
        }

        private void SetDirection()
        {
            if(buttons[0].IsPressed && buttons[1].IsPressed) direction.Set(45);
            if(buttons[0].IsPressed && buttons[3].IsPressed) direction.Set(315);
            if(buttons[1].IsPressed && buttons[2].IsPressed) direction.Set(135);
            if(buttons[2].IsPressed && buttons[3].IsPressed) direction.Set(225);
            if(buttons[0].IsPressed) direction.Set(360);
            if(buttons[1].IsPressed) direction.Set(90);
            if(buttons[2].IsPressed) direction.Set(180);
            if(buttons[3].IsPressed) direction.Set(270);
            if (buttons.All(b => b.IsPressed == false)) direction.Set(0);
        }

        private string GetDirection()
        {
            SetDirection();
            return (direction.Degree) switch
            {
                45 => "Up and Right",
                90 => "Right",
                135 => "Down and Right",
                180 => "Down",
                225 => "Down and Left",
                270 => "Left",
                315 => "Up and Left",
                360 => "Up",
                0 => "not Pressed"
              };
        }


        public override string Output()
        {
            return direction.Degree == 0?$"{Name} is {GetDirection()}":$"{Name} is pressed {GetDirection()}({direction.Degree})";
        }
    }
}
