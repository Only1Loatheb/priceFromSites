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
            const string priceAscRam3000mhz8gbDDR4 = "https://www.morele.net/komputery/podzespoly-komputerowe/pamieci-ram-38/,,,,,,,p,0,,7965O980523,7971O459459,7973O811795/1/";
            var ram = new List<Tuple<decimal, string>>();
            Parallel.For(1, 6, i => {
                string link = search.getUrlToNFromSearchUrl(priceAscRam3000mhz8gbDDR4, i);
                ram.Add(new Tuple<decimal, string>(morele.getPriceFromUrl(link), link));
            });
            ram.Sort((r1,r2)=>r1.Item1.CompareTo(r2.Item1));
            ram.ForEach(r => Console.WriteLine("Cena: {0} Link: {1}",r.Item1,r.Item2));
            //string link = search.getUrlToFirstFromSearchUrl(priceAscRam3000mhz8gbDDR4);
            //Console.WriteLine("Najtańszy RAM: {0} link: {1}", morele.getPriceFromUrl(link), link);

            //Parallel.For(1, 6, i => Console.WriteLine("Pozycja: {0} link: {1}",i,search.getUrlToNFromSearchUrl(priceAscRam3000mhz8gbDDR4,i )));
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
