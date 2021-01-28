using System;
using System.Collections.Generic;
using System.Text;

namespace ClickerGame
{
    interface ICommand
    {
        void Run();
        char Character { get; }
    }
}
