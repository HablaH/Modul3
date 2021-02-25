using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using ConsoleGame;

namespace RndGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var screen = new Screen();
            while (true) 
            { 
                screen.Update();
            }
        }
    }
}
