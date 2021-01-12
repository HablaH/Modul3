using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestBool
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] boolArray = new bool[3] { false, false, true};
            bool truth = boolArray.All((x) => x);
            Console.WriteLine(truth);
            
            
            
            string[] stringArray = new string[3] { "hi", "hi", "hi"};
            bool tru = stringArray.Any((x) => x.Contains('e'));
            Console.WriteLine(tru);
        }
    }
}
