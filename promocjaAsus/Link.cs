using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promocjaAsus
{
    class Link
    {
        public string link { get; }
        public Mobo name { get; }
       
        public Link(string l, Mobo n)
        {
            link = l;
            name = n;
        }
    }
}
