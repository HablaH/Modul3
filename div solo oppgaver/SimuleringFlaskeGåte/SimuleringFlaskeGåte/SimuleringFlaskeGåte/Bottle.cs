using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuleringFlaskeGåte
{
    class Bottle
    {
        public int Capacity { get; private set; }
        public int Content { get; set; }

        public Bottle(int capacity)
        {
            Capacity = capacity;
        }

        public void FillToTopFromTap()
        {
            Content = Capacity;
        }

        public void Fill(int content)
        {
            if (content == 0) return;
            if (content + Content <= Capacity) Content += content;
            else if (content + Content > Capacity) Content = Capacity;
        }

        public int Empty()
        {
            int content = Content;
            Content = 0;
            return content;
        }

        public void FillToTop(Bottle otherBottle)
        {
            int b1Initial = Content;
            int b2Initial = otherBottle.Content;

            if (b1Initial + b2Initial >= Capacity)
            {
                Content = Capacity;
                otherBottle.Content = (b2Initial - Capacity) + b1Initial;
            }
            else return;
        }

    }
}
