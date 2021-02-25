using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestChallenges
{
    class Challenge
    {
        
        public static int PairCount(string socks)
        {
            int count = 0;
            var something = socks.GroupBy(c => c).Select(c => new {Char = c.Key, Count = c.Count()});
            foreach (var x in something)
            {
                Console.WriteLine(x.Char);
                count += x.Count / 2;
            }
            return count;
        }
    }
}
