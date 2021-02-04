using System;
using System.Security.Cryptography.X509Certificates;

namespace Controller
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new Controller();
            Console.WriteLine(controller.Print());
            
            Console.ReadKey();
            controller.X.Use();
            controller.R2.Use(50);
            controller.LStick.Use(180, 100);
            controller.directional.Use(1);
            controller.directional.Use(0);
            Console.WriteLine(controller.Print());
            Console.ReadKey();
            controller.directional.Use(0);
            Console.WriteLine(controller.Print());
        }
    }
}
