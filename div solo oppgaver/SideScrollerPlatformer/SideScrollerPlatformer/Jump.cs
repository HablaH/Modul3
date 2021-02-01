using System;
using System.Collections.Generic;
using System.Text;

namespace SideScrollerPlatformer
{
    class Jump : ICommand
    {
        public char Character { get; }

        public Jump(char keyBind = 'w')
        {
            Character = keyBind;
        }
        public bool TryRun(char input, Object obj)
        {
            if (input == Character)
            {
                Player player = (Player)obj;
                if (player.IsFalling) return true;
                player.Move(new Vector(0, -2));
                //Console.Beep(150,50);
                return true;
            }

            return false;
        }
    }
}
