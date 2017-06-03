using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace promocjaAsus
{
    class MorelePrice
    {
        System.Net.WebClient wc = new System.Net.WebClient();
        Regex regex = new Regex("<div class=\"value\" id=\"product_price_brutto\" itemprop=\"price\" content=\"([0-9]*\\.?[0-9]*)\">");

        public Motherboard getPriceFromLink(Link link)
        {

            byte[] raw = wc.DownloadData(link.link);
            string webData = System.Text.Encoding.UTF8.GetString(raw);
            Match match = regex.Match(webData);
            
            decimal price = System.Convert.ToDecimal(match.Groups[1].Value.Replace(".",","));
            return new Motherboard(price, link.name);

        }
    }
}
