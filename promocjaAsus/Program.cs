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

             MoreleSearch search = new MoreleSearch();
            const string ram3000mhz8gbDDR4 = "https://www.morele.net/komputery/podzespoly-komputerowe/pamieci-ram-38/,,,,,,,p,0,,7965O980523,7971O459459,7973O811795/1/";
            Console.WriteLine("Najtańszy RAM: {0}",morele.getPriceFromUrl(search.getUrlToCheapestFromSearchUrl(ram3000mhz8gbDDR4)));
            
            /*
            Parallel.ForEach(linksMorele.links, (link)=>
            {
                Motherboard m = morele.getMoboFromLink(link);
                Console.WriteLine("{0} {1}", m.name.ToString(), m.price - cb.getCashbackValue(m.name, CPU.i5_7600K));
            });
           */
            System.Console.ReadKey();
        }
    }
}
