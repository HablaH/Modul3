using System;
using System.Collections.Generic;
using System.Text;

namespace SideScrollerPlatformer
{
    class MoveRight:ICommand
    {
        public char Character { get; }

        public MoveRight(char keyBind = 'd')
        {
            Character = keyBind;
        }
        public bool TryRun(char input, Object obj)
        {
            if (input == Character)
            {
                Player player = (Player)obj;
                player.Move(new Vector(1, 0));
                return true;
            }

            return false;
        }
    }
}
