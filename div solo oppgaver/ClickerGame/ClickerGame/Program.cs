using System;

namespace ClickerGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            var commandSet = new CommandSet(game);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Kommandoer:" +
                                  "\r\n - SPACE = klikk (og få poeng)" +
                                  "\r\n - U = kjøp oppgradering \r\n       øker poeng per klikk \r\n       koster 10 poeng" +
                                  "\r\n - S = kjøp superoppgradering \r\n       øker \"poeng per klikk\" for den vanlige oppgraderingen.\r\n       koster 100 poeng" +
                                  "\r\n - X = avslutt applikasjonen");
                Console.WriteLine($"Du har {game.Points} poeng.");
                Console.WriteLine("Trykk en tast for ønsket kommando");
                var command = Console.ReadKey().KeyChar;
                commandSet.Run(command);
            }
        }
    }
}
