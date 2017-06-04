using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promocjaAsus
{
    class Link
    {
        public string url { get; }
        public Mobo name { get; }
       
        public Link(string l, Mobo n)
        {
            url = l;
            name = n;
        }
    }
}
