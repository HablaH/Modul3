using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HvaGjørKodenOO
{
    class Counter
    {
        private readonly int _range;
        public int[] Counts;

        public Counter(int range)
        {
            _range = range;
            Counts = new int[range];
        }

        public void CountCharacters(string text)
        {
            foreach (var character in text.ToLower())
            {
                Counts[(int)character]++;
            }
        }

        public void ListCount()
        { 
            float sum = Counts.Sum();
            for (var i = 0; i < _range; i++)
            {
                if (Counts[i] <= 0) continue;
                
                var decimalFractionOfSum = Counts[i] / sum;
                var character = (char)i;
                Console.WriteLine($"{character} - {Counts[i]} - {decimalFractionOfSum:P3}");
            }
        }
    }    
}
