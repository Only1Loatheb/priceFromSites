using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace promocjaAsus
{
    class MorelePrice
    {
        HtmlWeb web = new HtmlWeb();

        public decimal getPriceFromUrl(string url)
        {
            HtmlDocument doc = web.Load(url);
            var priceTag = doc.GetElementbyId("product_price_brutto");
            return Convert.ToDecimal(priceTag.GetAttributeValue("content", "99999.0").Replace(".", ","));
        }
    }
}
/*
public Motherboard getMoboFromLink(LinkMobo link)
{
    HtmlDocument doc = web.Load(link.url);
    var priceTag = doc.GetElementbyId("product_price_brutto");
    decimal price = Convert.ToDecimal(priceTag.GetAttributeValue("content", "99999.0").Replace(".", ","));
    return new Motherboard(price, link.name);
}
*/
//byte[] raw = wc.DownloadData(link.link);
//string webData = System.Text.Encoding.UTF8.GetString(raw);
//Regex regex = new Regex("<div class=\"value\" id=\"product_price_brutto\" itemprop=\"price\" content=\"([0-9]*\\.?[0-9]*)\">");
//Match match = regex.Match(webData);
//decimal price = System.Convert.ToDecimal(match.Groups[1].Value.Replace(".",","));