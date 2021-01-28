using System;
using System.Collections.Generic;
using System.Text;

namespace SideScrollerPlatformer
{
    interface ICommand
    {
        bool TryRun(char input, Object obj);
        char Character { get; }
    }
}
