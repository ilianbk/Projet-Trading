using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TradingFinalProject.AllDataInfo;

namespace TradingFinalProject.Apicalls
{
    internal class Tradingsignalapi
    {

        static readonly HttpClient client = new();
        public static async Task<TradingSignalData> GetTradingSignal(string path)
        {
            HttpResponseMessage getter = await client.GetAsync(path);
            TradingSignalData linq = await getter.Content.ReadAsAsync<TradingSignalData>();
            return linq;
        }
    }
}
