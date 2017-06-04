using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace promocjaAsus
{
    class Program
    {
        static void Main(string[] args)
        {
            MorelePrice morele = new MorelePrice();
            LinksMorele linksMorele = new LinksMorele();
            Cashback cb = new Cashback();

            Parallel.ForEach(linksMorele.links, (link)=>
            {
                Motherboard m = morele.getPriceFromLink(link);
                Console.WriteLine("{0} {1}", m.name.ToString(), m.price - cb.getCashbackValue(m.name, CPU.i5_7600K));
            });
           
            System.Console.ReadKey();
        }
    }
}
