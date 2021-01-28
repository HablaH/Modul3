using System;
using System.Threading;
using System.Windows.Input;

namespace SideScrollerPlatformer
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid = new Grid(80,20);
            var screen = new Screen(grid);
            var player = new Player(new Vector(0, 10), '&', grid);
            var inputManager = new InputManager(player);
            var gravityManager = new GravityManager(grid, player);
            grid.FillHorizontal(19, '█');
            Console.WriteLine(grid);


            
            while (true)
            {
                Thread.Sleep(250);
                gravityManager.IsFalling();
                if (grid.HasBeenAltered|| Console.KeyAvailable) 
                {
                    if (Console.KeyAvailable && !player.IsMoving) 
                    { 
                        var key = Console.ReadKey().KeyChar;
                        inputManager.HandleInput(key);
                        
                    }

                    gravityManager.Fall();
                    
                    screen.Update();

                    Console.WriteLine(player.Position);
                    Console.WriteLine(player.IsFalling);
                   
                }

                if (player.IsMoving) player.IsMoving = false;
            }
        }
    }
}
