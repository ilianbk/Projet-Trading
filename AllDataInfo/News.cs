using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TradingFinalProject.AllDataInfo
{

    public class Data2
    {
        public int published_on { get; set; }
        public string? title { get; set; }
        public string? url { get; set; }

    }

    public class newsData
    {
        public List<Data2>? Data { get; set; }
    }
}
