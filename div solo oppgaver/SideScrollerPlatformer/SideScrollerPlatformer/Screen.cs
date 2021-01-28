using System;
using System.Collections.Generic;
using System.Text;

namespace SideScrollerPlatformer
{
    class Screen
    {
        private Grid _grid;

        public Screen(Grid grid)
        {
            _grid = grid;
        }
        public void Update()
        {
            Console.Clear();
            Console.WriteLine(_grid);
            _grid.HasBeenAltered = false;
        }
    }
}
