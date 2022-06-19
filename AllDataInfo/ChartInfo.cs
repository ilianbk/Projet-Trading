using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace TradingFinalProject
{
    public class Data
    {
        public double close { get; set; }
    }

    public class DataMain
    {
        public List<Data> Data { get; set; }
    }

    public class HistData
    {
        public DataMain Data { get; set; }
    }

}
