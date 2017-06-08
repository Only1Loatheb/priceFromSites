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
        private const string domain = "https://www.morele.net";
        private const string first = "//*[@id=\"content\"]/div/div[2]/div[2]/div[2]/div[7]/div[1]/div/div[1]/div/div[2]/div[1]/div[1]/div[2]/a";                         

        public string getUrlToFirstFromSearchUrl(string search) {
            HtmlDocument doc = web.Load(search);
            String cheapestProduct = domain + doc.DocumentNode.SelectSingleNode(first).GetAttributeValue("href", "https://www.morele.net/procesor-intel-core-i7-6950x-3ghz-25-mb-box-bx80671i76950x-774250/"); //DocumentNode.SelectSingleNode("//div[@id='comic']//img");
            return cheapestProduct;
        }
        public string getUrlToNFromSearchUrl(string search,int n)
        {
            int tableNo = (int) Math.Floor((double)n / 3.0) + 1;
            int rowNo = n % 3 + 1;
            string selector = String.Format("//*[@id=\"content\"]/div/div[2]/div[2]/div[2]/div[7]/div[{0}]/div/div[{1}]/div/div[2]/div[1]/div[1]/div[2]/a",
                tableNo,rowNo);
         HtmlDocument doc = web.Load(search);
            String cheapestProduct = domain + doc.DocumentNode.SelectSingleNode(selector).GetAttributeValue("href", "https://www.morele.net/procesor-intel-core-i7-6950x-3ghz-25-mb-box-bx80671i76950x-774250/"); //DocumentNode.SelectSingleNode("//div[@id='comic']//img");
            return cheapestProduct;
        }
    }
}
