using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TradingFinalProject.AllDataInfo;

namespace TradingFinalProject.Apicalls
{
    internal class Newsapi
    {
        static readonly HttpClient client = new();

        public static async Task<newsData> GetNews(string path)
        {
            HttpResponseMessage getter = await client.GetAsync(path);
            newsData linq = await getter.Content.ReadAsAsync<newsData>();
            return linq;
        }
    }
}
