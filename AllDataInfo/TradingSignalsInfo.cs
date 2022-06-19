using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TradingFinalProject.AllDataInfo
{
    public class InOutVar
    {
        public string sentiment { get; set; }
    }

    public class LargetxsVar
    {
        public string sentiment { get; set; }
    }

    public class AddressesNetGrowth
    {
        public string sentiment { get; set; }
    }

    public class ConcentrationVar
    {
        public string sentiment { get; set; }
 
    }

    public class SignalTools
    {
        public InOutVar inOutVar { get; set; }
        public LargetxsVar largetxsVar { get; set; }
        public AddressesNetGrowth addressesNetGrowth { get; set; }
        public ConcentrationVar concentrationVar { get; set; }
    }

    public class TradingSignalData
    {
        public SignalTools Data { get; set; }
    }
}
    

