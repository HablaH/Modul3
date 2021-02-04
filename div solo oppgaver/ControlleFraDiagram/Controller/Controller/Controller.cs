using System;
using System.Collections.Generic;
using System.Text;

namespace Controller
{
    class Controller
    {
        public Button A = new Button("A");
        public Button B = new Button("B");
        public Button X = new Button("X");
        public Button Y = new Button("Y");
        public Button L1 = new Button("L1");
        public Button R1 = new Button("R1");
        public Trigger L2 = new Trigger("L2");
        public Trigger R2 = new Trigger("R2");
        public Stick LStick = new Stick("Left");
        public Stick RStick = new Stick("Right");
        public DPad directional = new DPad("directional");

        private Input[] inputs;

        public Controller()
        {
            inputs = new Input[] {A, B, X, Y, L1, R1, L2, R2, LStick, RStick, directional};
        }

        public string Print()
        {
            var sb = new StringBuilder();
            foreach (var input in inputs)
            {
                sb.AppendLine(input.Output());
            }

            return sb.ToString();
        }


    }
}
