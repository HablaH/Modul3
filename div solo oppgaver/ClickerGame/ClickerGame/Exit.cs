using System;
using System.Collections.Generic;
using System.Text;

namespace ClickerGame
{
    class Exit:ICommand
    {
        public char Character { get; } = 'x';

        public void Run()
        {
            Environment.Exit(0);
        }
    }
}
