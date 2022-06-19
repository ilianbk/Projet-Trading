using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TradingFinalProject.AllDataInfo;

namespace TradingFinalProject.Apicalls
{
    internal class Socialapi
    {
        static readonly HttpClient client = new();

        public static async Task<SocialDataa> GetSocial(string path)
        {
            HttpResponseMessage getter = await client.GetAsync(path);
            SocialDataa linq = await getter.Content.ReadAsAsync<SocialDataa>();
            return linq;
        }
    }
}
