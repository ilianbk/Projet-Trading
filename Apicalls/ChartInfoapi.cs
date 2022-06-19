using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TradingFinalProject.Apicalls
{
    internal class ChartInfoapi
    {
        static readonly HttpClient client = new();
        public static async Task<HistData> GetChartInfo(string path)
        {
            HttpResponseMessage getter = await client.GetAsync(path);
            HistData linq = await getter.Content.ReadAsAsync<HistData>();
            return linq;
        }

        public static DateTime ToDateTime(double unixTimeStamp)
        {
            DateTime dateTime = new(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }
    }
}
