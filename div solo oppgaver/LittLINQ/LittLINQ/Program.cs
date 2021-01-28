using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace LittLINQ
{
    class Program
    {
        public static int[] intArr = new[] {4, 8, 6, 2, 5, 7, 1, 6, 4, 3, 8};
        public static int[] intArr2 = new[] {5,7,6,9,2,4,3,6,8,10,15,4};
        public static string[] strArr = new[] {"Hei", "på", "deg", "din", "gamle", "sei"};
        public static string[] strArr2 = new[] {"Hei123",null, "på",null, "456deg6", "234din", "gamle456", "sei"};
        public static bool[] boolArr = new[] {true, false, false, true, false, true, true, true};

        static void Main(string[] args)
        {

            ////tall
            //Console.Write("Orginal array: ");
            //intArr.ToList().ForEach(i => Console.Write(i + " "));

            //Console.WriteLine();

            ////where
            //var arr1 = intArr.Where(n => n < 5);
            //Console.Write("\nArray med tall under 5: ");
            //arr1.ToList().ForEach(i => Console.Write(i + " "));

            //Console.WriteLine();

            //var arr2 = from int n in intArr where n > 5 select n;
            //Console.Write("\nArray med tall over 5: ");
            //arr2.ToList().ForEach(i => Console.Write(i + " "));

            //Console.WriteLine();
            ////OrderBy
            //var arr3 = intArr.OrderBy(i => i).Where(i => i < 5);
            //Console.Write("\nArray med tall i stigende rekkefølge: ");
            //arr3.ToList().ForEach(i => Console.Write(i + " "));

            //Console.WriteLine();

            //var arr4 = intArr.OrderByDescending(i => i);
            //Console.Write("\nArray med tall i synkende rekkefølge: ");
            //arr4.ToList().ForEach(i => Console.Write(i + " "));

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("string sortering");
            //var arrrrrr = strArr.OrderBy(s => s);
            //Console.Write("\nlengden på ord stigende rekkefølge: ");
            //arrrrrr.ToList().ForEach(i => Console.Write(i + " "));



            ////Average
            //var avgOfArr = intArr.Average();
            //Console.WriteLine($"Gjennomsnitt av array: {avgOfArr}");

            //Console.WriteLine();

            ////Sum
            //var sumOfArr = intArr.Where(i => i<5).Sum();
            //Console.WriteLine($"Summen av array: {sumOfArr}");

            //Console.WriteLine();
            ////All
            //var isAll = intArr2.All(i => i < 10);
            //Console.WriteLine("Alle verdier er " + (isAll ? "" : "ikke ") + "mindre enn 10");

            //Console.WriteLine();
            ////any
            //var isAny = intArr2.Any(i => i == 15 || i > 10);
            //Console.WriteLine((isAny ? "Noen " : "Ingen ") + "verdier er mer enn 10 eller lik 15");


            //string

            //strArr.Where(s => s.Contains('e')).ToList().ForEach(s => Console.Write(s + " "));

            //var strList = strArr.Where(s => s.Contains('e'));

            //Console.WriteLine();
            //Console.WriteLine();


            //students
            //query score
            //Student.QueryHighScores(1, 90);
            //Console.WriteLine("Press any key to exit");
            //Console.ReadKey();

            //group by last name
            Student.GroupBySingleProperty();
        }
    }
}
