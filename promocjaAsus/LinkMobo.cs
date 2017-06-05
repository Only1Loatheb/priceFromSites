using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promocjaAsus
{
    class LinkMobo
    {
        public string url { get; }
        public Mobo name { get; }
       
        public LinkMobo(string l, Mobo n)
        {
            url = l;
            name = n;
        }
    }
}
