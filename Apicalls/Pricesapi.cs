using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TradingFinalProject.AllDataInfo;

namespace TradingFinalProject.Apicalls
{
    internal class Pricesapi
    {
        static readonly HttpClient client = new();


        public static async Task<CoinPrices> GetProductAsync(string path)
        {
            HttpResponseMessage getter = await client.GetAsync(path);
            CoinPrices linq = await getter.Content.ReadAsAsync<CoinPrices>();
            return linq;
        }
    }
}
