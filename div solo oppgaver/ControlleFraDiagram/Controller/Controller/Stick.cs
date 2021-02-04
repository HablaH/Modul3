using System;
using System.Collections.Generic;
using System.Text;

namespace Controller
{
    class Stick:Input
    {
        /*public string Name { get; }*/
        public Button button;
        public Trigger trigger;
        public Direction direction;

        public Stick(string name):base(name)
        {
            //Name = name;
            button = new Button("STK BTN " + name);
            trigger = new Trigger("STK" + name);
            direction = new Direction();
        }

        public override void Use()
        {
            
        }

        public void Use(int dir, int per)
        {
            direction.Set(dir);
            trigger.Use(per);
        }

        public override string Output()
        {
            var sb = new StringBuilder();
            sb.AppendLine(button.Output());
            sb.AppendLine(trigger.button.IsPressed
                ? $"{Name} leans {trigger.percent.Percentile}% to direction {direction.Degree} degrees"
                : $"{Name} is not used");
            return sb.ToString();
        }
    }
}
