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
        private const string priceAscRam3000mhz8gbDualDDR4 = "https://www.morele.net/komputery/podzespoly-komputerowe/pamieci-ram-38/,,,,,,,p,0,,7965O980523,7971O459459,7973O811795,21239O665142/1/";

        static void Main(string[] args)
        {
            Cashback cb = new Cashback();
            Morele m = new Morele();
            LinksMorele moreleLinks = new LinksMorele();
            var fastRam = m.getPairsPriceUrlFromSearches(moreleLinks.ram16GBDualDifferentSpeed);
            fastRam.Sort((r1, r2) => r1.Item1.CompareTo(r2.Item1));
            fastRam.ForEach(r => Console.WriteLine("Cena:{0} Link:{1}", r.Item1, r.Item2));
            
            var rams = m.getTopNPairsPriceUrlFromSearch(priceAscRam3000mhz8gbDualDDR4, 20);
            rams.ForEach(r => Console.WriteLine("Cena:{0} Link:{1}", r.Item1, r.Item2));

            var mobos = m.getTriplesPriceLinkNameToAsusMobos();
            mobos.ForEach(r => Console.WriteLine("Cena:{0} Nazwa:{1} Link:{2}", r.Item1 - cb.getCashbackValue(r.Item2, CPU.i5_7600K), r.Item2.ToString(), r.Item3));
            
            System.Console.ReadKey();
        }
    }
}
