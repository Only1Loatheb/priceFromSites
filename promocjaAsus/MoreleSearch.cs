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
        private const string bad = "https://www.morele.net/procesor-intel-core-i7-6950x-3ghz-25-mb-box-bx80671i76950x-774250/";
        public string getUrlToFirstFromSearchUrl(string search) {
            HtmlDocument doc = web.Load(search);
            return  domain + doc.DocumentNode.SelectSingleNode(first).GetAttributeValue("href", bad);
            
        }

        public List<string> getUrlsToNFromSearchUrl(string search, int n)
        {
            HtmlDocument doc = web.Load(search);
            var links = new  List<string>();
            int tables = (int)Math.Floor(n / 3.0);
            for (int tableNo = 1; tableNo <= tables; ++tableNo)
            {
                for (int rowNo = 1; (tableNo - 1) * 3 + rowNo - 1 < n && rowNo <= 3; ++rowNo)
                {
                    //Console.WriteLine("{0}{1}{2}", tableNo, rowNo,tables);
                    string selector = String.Format("//*[@id=\"content\"]/div/div[2]/div[2]/div[2]/div[7]/div[{0}]/div/div[{1}]/div/div[2]/div[1]/div[1]/div[2]/a",
                        tableNo, rowNo);
                    try
                    {
                        string href = doc.DocumentNode.SelectSingleNode(selector).GetAttributeValue("href", "");
                        StringBuilder sb = new StringBuilder(domain);
                        sb.Append(href);
                        links.Add(sb.ToString());
                    }
                    catch
                    {
                        return links;
                    }
                }
            }
            return links;
        }

        public string getUrlToIFromSearchUrl(string search,int n)
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
