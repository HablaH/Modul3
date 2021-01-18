using System;
using System.Text;

namespace SimuleringFlaskeGåte
{
    class Program
    {
        static void Main(string[] args)
        {
            var bottle1 = new Bottle(5);
            var bottle2 = new Bottle(7);
            //int[] ops = new[] { 0,2,0,4,7,2,0,4};
            //DoOperations(ops, bottle1, bottle2);
            //Console.WriteLine($"1: {bottle1.Content}  2: {bottle2.Content}");
            //CheckIfSolvedAndExitApplicationIfSo(bottle1, bottle2, 6, ops);

            TryWithGivenNumberOfOperations(10, bottle1, bottle2, 3);
        }

        private static void TryWithGivenNumberOfOperations(int numberOfOperations, Bottle bottle1, Bottle bottle2, int wantedVolume)
        {
            Console.WriteLine("Prøver med " + numberOfOperations + " operasjon(er).");
            var operations = new int[numberOfOperations];
            while (true)
            {
                DoOperations(operations, bottle1, bottle2);
                CheckIfSolvedAndExitApplicationIfSo(bottle1, bottle2, wantedVolume, operations);
                var success = UpdateOperations(operations);
                if (!success) break;
            }
        }

        private static void DoOperations(int[] operations, Bottle bottle1, Bottle bottle2)
        {
            bottle1.Empty();
            bottle2.Empty();
            for (int i= 0; i < operations.Length; i++)
            {
                int operationNo = operations[i];
                if (operationNo == 0) continue;
                else if (operationNo == 1) bottle1.FillToTopFromTap(); // Fylle flaske 1 fra springen
                else if (operationNo == 2) bottle2.FillToTopFromTap(); // Fylle flaske 2 fra springen
                else if (operationNo == 3) bottle2.Fill(bottle1.Empty()); // Tømme flaske 1 i flaske 2 - 
                // Tanken er at Empty() returnerer hvor mye det var i flasken før den ble tømt
                else if (operationNo == 4) bottle1.Fill(bottle2.Empty()); // Tømme flaske 2 i flaske 1
                else if (operationNo == 5) bottle2.FillToTop(bottle1); // Fylle opp flaske 2 med flaske 1
                // Tanken er at FillToTop tar en annen Bottle som parameter. Hvis det er nok, fyller den 
                // bottle2 og reduserer bottle1 tilsvarende. Hvis ikke gjør den ingenting.
                else if (operationNo == 6) bottle1.FillToTop(bottle2); // Fylle opp flaske 1 med flaske 2
                else if (operationNo == 7) bottle1.Empty(); // Tømme flaske 1 (kaste vannet)
                else if (operationNo == 8) bottle2.Empty(); // Tømme flaske 2 (kaste vannet)
            }
        }

        private static void CheckIfSolvedAndExitApplicationIfSo(Bottle bottle1, Bottle bottle2, int wantedVolume,
            int[] operations)
        {
            if (bottle1.Content == wantedVolume || bottle2.Content == wantedVolume)
            {
                StringBuilder operationsText = new StringBuilder();
                foreach (var operation in operations)
                {
                        operationsText.Append(operation.ToString() + " - ");
                }
                Console.WriteLine($"Fant ønsket volum ved operasjon {operationsText.ToString()}" );
                Environment.Exit(-1);
            }
        }

        private static bool UpdateOperations(int[] operations)
        {
            int i;
            for (i = operations.Length - 1; i >= 0; i--)
            {
                if (operations[i] < 7)
                {
                    operations[i]++;
                    break;
                }
                operations[i] = 0;
            }
            return i != -1;
        }
    }
}
