using System;

namespace HvaGjørKodenOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = new Counter(255);
            while (true)
            {
                counter.CountCharacters(Console.ReadLine());
                counter.ListCount();
            }
        }
    }
}
