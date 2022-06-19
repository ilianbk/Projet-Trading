using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TradingFinalProject.AllDataInfo;

namespace TradingFinalProject.Apicalls
{
    internal class Symbolapi
    {
        static readonly HttpClient client = new();

        public static async Task<symbolData> GetSymbolInfo(string path)
        {
            HttpResponseMessage getter = await client.GetAsync(path);
            symbolData linq = await getter.Content.ReadAsAsync<symbolData>();
            return linq;
        }
    }
}
