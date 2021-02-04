using System;
using System.Collections.Generic;
using System.Text;

namespace Controller
{
    class Trigger : Input
    {
        //public string Name { get; }
        public Button button { get; }
        public Percent percent { get; }

        public Trigger(string name):base(name)
        {
            button = new Button("TRG " + name);
            percent = new Percent();
        }

        public override void Use()
        {
            button.Use();
        }

        public void Use(int value)
        {
            percent.Set(value);
            if (percent.Percentile > 0) button.Use();
        }

        public override string Output()
        {
            return button.IsPressed ? $"{Name} is pressed {percent.Percentile}% in": $"{Name} is not pressed";
        }
    }
}
