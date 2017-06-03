using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promocjaAsus
{
    class Motherboard
    {
        public Motherboard(decimal price ,Mobo name )
        {
            this.price = price;
            this.name = name;
        }
        public decimal price { get; }
        public Mobo name { get; }
    }
}
