using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingFinalProject.AllDataInfo
{


    public class CryptoCompare
    {
        public int Points { get; set; }
        public int Followers { get; set; }
        public int Posts { get; set; }
        public int Comments { get; set; }
    }

    public class Twitter
    {
        public int Points { get; set; }
        public string account_creation { get; set; }
        public int followers { get; set; }
        public int favourites { get; set; }
    }

    public class Reddit
    {
        public int Points { get; set; }
        public int active_users { get; set; }
        public string community_creation { get; set; }
        public int subscribers { get; set; }
    }

    public class Facebook
    {
        public string Points { get; set; }
        public int talking_about { get; set; }
        public string likes { get; set; }
    }

    public class AllSocial
    {
        public CryptoCompare CryptoCompare { get; set; }
        public Twitter Twitter { get; set; }
        public Reddit Reddit { get; set; }
        public Facebook Facebook { get; set; }
    }

    public class SocialDataa
    {
        public AllSocial Data { get; set; }
    }
}
