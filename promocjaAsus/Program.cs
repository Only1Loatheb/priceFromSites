using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            foreach(var l in linksMorele.links)
            {
                Motherboard m = morele.getPriceFromLink(l);
                System.Console.Write(m.name.ToString() + " ");
                System.Console.WriteLine(m.price - cb.getCashbackValue(m.name,CPU.i5_7600K));
            }
           
            System.Console.ReadKey();
        }
    }
}
