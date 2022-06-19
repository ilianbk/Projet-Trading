using System;
using System.Collections.Generic;
using System.Windows;
using TradingFinalProject.AllDataInfo;
using TradingFinalProject.Apicalls;
using TradingFinalProject.Wpf;

namespace TradingFinalProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            DateTime dateTime = new(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }

        private async void GetBTCPrices(string URL)
        {
            BTCPrice bTCPrice = await BTCapi.GetBTCPrice(URL);
            usd.Content = bTCPrice.USD.ToString();
            eur.Content = bTCPrice.EUR.ToString();
            jpy.Content = bTCPrice.JPY.ToString();
        }
        private async void GetETHPrices(string URL)
        {
            ETHPrice eTHPrice = await ETHapi.GetETHPrice(URL);
            usd_Copy.Content = eTHPrice.USD.ToString();
            eur_Copy.Content = eTHPrice.EUR.ToString();
            jpy_Copy.Content = eTHPrice.JPY.ToString();
        }
        private async void GetNews(string URL)
        {
            newsData news = await Newsapi.GetNews(URL);


            List<string> titles = new();
            List<string> links = new();
            List<string> dates = new();

            foreach (var item in news.Data)
            {
                titles.Add(item.title);
                links.Add(item.url);
                dates.Add(UnixTimeStampToDateTime(item.published_on).ToString());

            }

            string[] titlesArray = titles.ToArray();
            string[] linksArray = links.ToArray();
            string[] datesArray = dates.ToArray();

            title1.Text = titlesArray[0];
            title2.Text = titlesArray[1];


            link1.Text = linksArray[0];
            link2.Text = linksArray[1];

            date1.Text = datesArray[0];
            date2.Text = datesArray[1];

        }
        public MainWindow()
        {
            InitializeComponent();
            this.GetNews("https://min-api.cryptocompare.com/data/v2/news/?lang=EN&api_key=ba83c829e44248d3def594fb09b4290c67032502fafa324f030c2fb9390a95f1");
            this.GetBTCPrices("https://min-api.cryptocompare.com/data/price?fsym=BTC&tsyms=USD,JPY,EUR&api_key={ba83c829e44248d3def594fb09b4290c67032502fafa324f030c2fb9390a95f1}");
            this.GetETHPrices("https://min-api.cryptocompare.com/data/price?fsym=ETH&tsyms=USD,JPY,EUR&api_key={ba83c829e44248d3def594fb09b4290c67032502fafa324f030c2fb9390a95f1}");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Chart win2 = new();
            this.Content = win2;
                                        
        }


        private void TradingSignals_Click(object sender, RoutedEventArgs e)
        {
            TradingSignals win2 = new();
            this.Content = win2;
        }

        private void CoinsAvailable_Click(object sender, RoutedEventArgs e)
        {
            CoinsAvailable w = new();
            this.Content = w;
        }


        private void SocialDatas_Click(object sender, RoutedEventArgs e)
        {
            SocialData soc = new SocialData();
            this.Content = soc;
        }
    }
}