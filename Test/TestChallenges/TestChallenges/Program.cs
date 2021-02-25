using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Method1();
            Method2();
            //Method3();
            Console.ReadKey();
            //Console.WriteLine(Challenge.PairCount("ACBACBCCA"));

            //Console.WriteLine(Challenge.ToCamelCase("asd_asd_asd_bsa"));
        }
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine($" Method 1 - {i}");
                    // Do something
                    Task.Delay(50).Wait();
                }
            });
        }


        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine($" Method 2 - {i}");
                // Do something
                Task.Delay(100).Wait();
            }
        }

        public static void Method3()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine($" Method 3 - {i}");
                // Do something
                Task.Delay(100).Wait();
            }
        }
    }
}
