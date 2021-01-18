using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace SimuleringFlaskeGåte
{
    class Program
    {
        //cd C:\Users\HablaH\Documents\Koding\Github\Modul3\div solo oppgaver\SimuleringFlaskeGåte\SimuleringFlaskeGåte\SimuleringFlaskeGåte\bin\Debug
        //SimuleringFlaskeGåte 
        static void Main(string[] args)
        {
            Bottle bottle1 = new Bottle(int.Parse(args[0]));
            Bottle bottle2 = new Bottle(int.Parse(args[1]));
            int wantedVolume = int.Parse(args[2]);
            int numberOfOperations = int.Parse(args[3]);

            Console.WriteLine($"flaske 1: {bottle1.Capacity} Liter  \r\n" +
                              $"flaske 2: {bottle2.Capacity} Liter  \r\n" +
                              $"ønket mengde : {wantedVolume} Liter \r\n" +
                              $"antall lovlige operasjoner: {numberOfOperations}");

            
            //var bottle1 = new Bottle(5);
            //var bottle2 = new Bottle(7);
            //int[] ops = new[] { 0,2,0,4,7,2,0,4};
            //DoOperations(ops, bottle1, bottle2);
            //Console.WriteLine($"1: {bottle1.Content}  2: {bottle2.Content}");
            //CheckIfSolvedAndExitApplicationIfSo(bottle1, bottle2, 6, ops);

            TryWithGivenNumberOfOperations(numberOfOperations, bottle1, bottle2, wantedVolume);
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
            foreach (var operation in operations)
            {
                if (operation == 1) bottle1.FillToTopFromTap();                 // Fylle flaske 1 fra springen
                else if (operation == 2) bottle2.FillToTopFromTap();            // Fylle flaske 2 fra springen
                else if (operation == 3) bottle2.Fill(bottle1.Empty());   // Tømme flaske 1 i flaske 2
                else if (operation == 4) bottle1.Fill(bottle2.Empty());   // Tømme flaske 2 i flaske 1
                else if (operation == 5) bottle2.FillToTop(bottle1);            // Fylle opp flaske 2 med flaske 1
                else if (operation == 6) bottle1.FillToTop(bottle2);            // Fylle opp flaske 1 med flaske 2
                else if (operation == 7) bottle1.Empty();                       // Tømme flaske 1 (kaste vannet)
                else if (operation == 8) bottle2.Empty();                       // Tømme flaske 2 (kaste vannet)
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
                Console.WriteLine($"Fant ønsket volum ved å: \r\n{OperationsToText(operations)}" );
                Environment.Exit(-1);
            }
        }

        private static string OperationsToText(int[] operations)
        {
            StringBuilder operationsText = new StringBuilder();
            foreach (var operation in operations)
            {
                if      (operation == 1) operationsText.Append($"({operation.ToString()}) Fylle flaske 1 \r\n");
                else if (operation == 2) operationsText.Append($"({operation.ToString()}) Fylle flaske 2 \r\n");
                else if (operation == 3) operationsText.Append($"({operation.ToString()}) Tømme flaske 1 i flaske 2 \r\n");
                else if (operation == 4) operationsText.Append($"({operation.ToString()}) Tømme flaske 2 i flaske 1 \r\n");
                else if (operation == 5) operationsText.Append($"({operation.ToString()}) Fylle opp flaske 2 med flaske 1 \r\n");
                else if (operation == 6) operationsText.Append($"({operation.ToString()}) Fylle opp flaske 1 med flaske 2 \r\n");
                else if (operation == 7) operationsText.Append($"({operation.ToString()}) Tømme flaske 1 \r\n");
                else if (operation == 8) operationsText.Append($"({operation.ToString()}) Tømme flaske 2 \r\n");
            }
            return operationsText.ToString();
        }

        private static bool UpdateOperations(int[] operations)
        {
            int i;
            for (i = operations.Length - 1; i >= 0; i--)
            {
                if (operations[i] < 8)
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
