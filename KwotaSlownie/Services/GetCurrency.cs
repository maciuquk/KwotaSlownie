using KwotaSlownie.Models;
using Microsoft.Toolkit.Parsers.Rss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace KwotaSlownie.Services
{
    public class GetCurrency
    {
        public static List<CurrencyModel> NBPCurrency()
        {
            var currencyList = new List<CurrencyModel>();
            return currencyList;
        }

        public async Task<List<CurrencyModel>> ParseRSS()
        {
            string feed = null;
            var currencyList = new List<CurrencyModel>();

            using (var client = new HttpClient())
            {
                try
                {
                    feed = await client.GetStringAsync("https://rss.nbp.pl/kursy/TabelaA.xml");
                }
                catch { } // TODO: Deal with unavailable resource.
            }

            if (feed != null)
            {
                var parser = new RssParser();
                var rss = parser.Parse(feed);

                foreach (var element in rss)
                {
                    // find Euro and add to currency

                    string stringAmount = element.Summary.Substring(170, 6);
                    decimal temporaryAmountDecimal = Convert.ToDecimal(stringAmount);
                    @currencyList.Add(new CurrencyModel { Info1 = element.Title, Info2 = element.Summary, Date = element.PublishDate.ToString("dd/MM/yyyy"), Currency = temporaryAmountDecimal });
                }
            }
            return currencyList;
        }
    }
}
