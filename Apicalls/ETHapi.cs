using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TradingFinalProject.AllDataInfo;

namespace TradingFinalProject.Apicalls
{
    internal class ETHapi
    {
        static readonly HttpClient client = new();

        public static async Task<ETHPrice> GetETHPrice(string path)
        {
            HttpResponseMessage getter = await client.GetAsync(path);
            ETHPrice eTHPrice = await getter.Content.ReadAsAsync<ETHPrice>();
            return eTHPrice;
        }
    }
}
