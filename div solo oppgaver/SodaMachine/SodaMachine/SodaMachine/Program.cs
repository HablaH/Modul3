using System;

namespace SodaMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var sm = new SodaMachine();
            while (true)
            {
                sm.HandleCommand(Console.ReadLine());
            }

        }
    }
}
