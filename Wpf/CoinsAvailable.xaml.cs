using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using TradingFinalProject.AllDataInfo;
using TradingFinalProject.Apicalls;

namespace TradingFinalProject
{
    /// <summary>
    /// Logique d'interaction pour CoinsAvailable.xaml
    /// </summary>
    public partial class CoinsAvailable : Page
    {
        public CoinsAvailable()
        {
            InitializeComponent();
            this.GetBinanceVolume("https://min-api.cryptocompare.com/data/exchange/top/volume?e=Binance&direction=TO&api_key=ba83c829e44248d3def594fb09b4290c67032502fafa324f030c2fb9390a95f1");
            this.GetKrakenVolume("https://min-api.cryptocompare.com/data/exchange/top/volume?e=Kraken&direction=TO&api_key=ba83c829e44248d3def594fb09b4290c67032502fafa324f030c2fb9390a95f1");
            this.GetCoinbaseVolume("https://min-api.cryptocompare.com/data/exchange/top/volume?e=Coinbase&direction=TO&api_key=ba83c829e44248d3def594fb09b4290c67032502fafa324f030c2fb9390a95f1");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TradingSignals_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow w = new();
            w.Show();
        }

        private async void GetBinanceVolume(string URL)
        {
            symbolData symb = await Symbolapi.GetSymbolInfo(URL);


            List<string> names = new();
            List<string> supplys = new();

            foreach (var item in symb.Data)
            {
                names.Add(item.toSymbol);
                supplys.Add(item.volume.ToString());
            }

            string[] nameArray = names.ToArray();
            string[] supplyArray = supplys.ToArray();

            coin1.Content = nameArray[0];
            coin2.Content = nameArray[1];
            coin3.Content = nameArray[2];
            coin4.Content = nameArray[3];
            coin5.Content = nameArray[4];

            volume1.Content = supplyArray[0];
            volume2.Content = supplyArray[1];
            volume3.Content = supplyArray[2];
            volume4.Content = supplyArray[3];
            volume5.Content = supplyArray[4];

        }
        private async void GetKrakenVolume(string URL)
        {
            symbolData symb = await Symbolapi.GetSymbolInfo(URL);


            List<string> names = new();
            List<string> supplys = new();

            foreach (var item in symb.Data)
            {
                names.Add(item.toSymbol);
                supplys.Add(item.volume.ToString());
            }

            string[] nameArray = names.ToArray();
            string[] supplyArray = supplys.ToArray();

            coin1_Copy.Content = nameArray[0];
            coin2_Copy.Content = nameArray[1];
            coin3_Copy.Content = nameArray[2];
            coin4_Copy.Content = nameArray[3];
            coin5_Copy.Content = nameArray[4];

            volume1_Copy.Content = supplyArray[0];
            volume2_Copy.Content = supplyArray[1];
            volume3_Copy.Content = supplyArray[2];
            volume4_Copy.Content = supplyArray[3];
            volume5_Copy.Content = supplyArray[4];

        }
        private async void GetCoinbaseVolume(string URL)
        {
            symbolData symb = await Symbolapi.GetSymbolInfo(URL);


            List<string> names = new();
            List<string> supplys = new();

            foreach (var item in symb.Data)
            {
                names.Add(item.toSymbol);
                supplys.Add(item.volume.ToString());
            }

            string[] nameArray = names.ToArray();
            string[] supplyArray = supplys.ToArray();

            coin1_Copy1.Content = nameArray[0];
            coin2_Copy1.Content = nameArray[1];
            coin3_Copy1.Content = nameArray[2];
            coin4_Copy1.Content = nameArray[3];
            coin5_Copy1.Content = nameArray[4];

            volume1_Copy1.Content = supplyArray[0];
            volume2_Copy1.Content = supplyArray[1];
            volume3_Copy1.Content = supplyArray[2];
            volume4_Copy1.Content = supplyArray[3];
            volume5_Copy1.Content = supplyArray[4];

        }

        private void CoinsAvailable_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SocialDatas_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
