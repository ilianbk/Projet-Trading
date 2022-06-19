using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TradingFinalProject.AllDataInfo;

namespace TradingFinalProject.Apicalls
{
    internal class BTCapi
    {

        static readonly HttpClient client = new();

        public static async Task<BTCPrice> GetBTCPrice(string path)
        {
            HttpResponseMessage getter = await client.GetAsync(path);
            BTCPrice eTHPrice = await getter.Content.ReadAsAsync<BTCPrice>();
            return eTHPrice;
        }
    }
}
