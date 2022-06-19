using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TradingFinalProject.AllDataInfo
{
    public class symbolData
    {
        public List<Data3> Data { get; set; }
    }

    public class Data3
    {
       public string toSymbol   { get; set; }
       public string fromSymbol { get; set; }
       public float volume { get; set; }
    }

}
