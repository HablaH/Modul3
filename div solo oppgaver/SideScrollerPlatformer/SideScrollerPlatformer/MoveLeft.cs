using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Windows.Input;

namespace SideScrollerPlatformer
{
    class MoveLeft:ICommand
    {
        public char Character { get; }

        public MoveLeft(char keyBind = 'a')
        {
            Character = keyBind;
        }
        public bool TryRun(char input, Object obj)
        {
            if (input == Character) 
            {
                Player player = (Player)obj;
                player.Move(new Vector(-1,0));
                return true;
            }

            return false;
        }
    }
}
