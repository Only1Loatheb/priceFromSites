using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promocjaAsus
{

    class Morele
    {
        MorelePrice priceMorele = new MorelePrice();
        LinksMorele linksMorele = new LinksMorele();
        MoreleSearch searchMorele = new MoreleSearch();

        public List<Tuple<decimal, string>> getTopNPairsPriceUrlFromSearch(string search, int n)
        {    
            var links = searchMorele.getUrlsToNFromSearchUrl(search, n);
            var items = getPairsPriceUrlFromLinks(links);
            items.Sort((r1, r2) => r1.Item1.CompareTo(r2.Item1));
            return items;
        }

        public List<Tuple<decimal, string>> getPairsPriceUrlFromLinks(List<string> links)
        {
            var items = new List<Tuple<decimal, string>>();
            Parallel.ForEach(links, link => {
                items.Add(new Tuple<decimal, string>(priceMorele.getPriceFromUrl(link), link));
            });
            return items;
        }


        public List<Tuple<decimal, string>> getPairsPriceUrlFromSearches(List<string> searches)
        {
            var items = new List<Tuple<decimal, string>>();
            Parallel.ForEach(searches, search => {
                string link = searchMorele.getUrlToFirstFromSearchUrl(search);
                items.Add(new Tuple<decimal, string>(priceMorele.getPriceFromUrl(link), link));
            });
            return items;
        }

        public Tuple<decimal, string> getTopPairPriceUrlFromSearch(string search)
        {
            string link = searchMorele.getUrlToFirstFromSearchUrl(search);
            return new Tuple<decimal, string>(priceMorele.getPriceFromUrl(link), link);
        }

        public List<Tuple<decimal, Mobo, string>> getTriplesPriceLinkNameToAsusMobos()
        {
            var mobos = new List<Tuple<decimal, Mobo, string>>();
            Parallel.ForEach(linksMorele.moboLinks, link =>
            {
                mobos.Add(new Tuple<decimal, Mobo, string>(priceMorele.getPriceFromUrl(link.url),link.name,link.url));
            });
            return mobos;
        }

           
    }
}
