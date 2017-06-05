using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace promocjaAsus
{
    class MoreleSearch
    {
        HtmlWeb web = new HtmlWeb();
        const string domain = "https://www.morele.net";
        const string selector = "//*[@id=\"content\"]/div/div[2]/div[2]/div[2]/div[7]/div[1]/div/div[1]/div/div[2]/div[1]/div[1]/div[2]/a";
        public string getUrlToCheapestFromSearchUrl(string search) {
            HtmlDocument doc = web.Load(search);
            String cheapestProduct = domain + doc.DocumentNode.SelectSingleNode(selector).GetAttributeValue("href", "https://www.morele.net/procesor-intel-core-i7-6950x-3ghz-25-mb-box-bx80671i76950x-774250/"); //DocumentNode.SelectSingleNode("//div[@id='comic']//img");
            return cheapestProduct;
        }
    }
}
