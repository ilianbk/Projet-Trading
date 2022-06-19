using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using TradingFinalProject.AllDataInfo;
using TradingFinalProject.Apicalls;

namespace TradingFinalProject
{
    /// <summary>
    /// Logique d'interaction pour Chart.xaml
    /// </summary>
    public partial class Chart : Page
    {
        public Chart()
        {
            InitializeComponent();
        }

        private void Button1D_Click(object sender, RoutedEventArgs e)
        {
            WpfPlot.Reset();
            Uri Uri = new("https://min-api.cryptocompare.com/data/v2/histohour?fsym=" + text1.Text + "&tsym=" + text2.Text + "&limit=1440&aggregate=1&e=CCCAGG&api_key={ba83c829e44248d3def594fb09b4290c67032502fafa324f030c2fb9390a95f1}");
          
            label1.Content = text1.Text;
            label2.Content = text2.Text;

            this.GetDataInMinute(Uri, 1);
            this.GetDataOnTime("https://min-api.cryptocompare.com/data/price?fsym=" + text1.Text + "&tsyms=BTC,USD,EUR,JPY,ETH&api_key={ba83c829e44248d3def594fb09b4290c67032502fafa324f030c2fb9390a95f1}");
        }


        private void Button7D_Click(object sender, RoutedEventArgs e)
        {
            WpfPlot.Reset();
            Uri Uri = new("https://min-api.cryptocompare.com/data/v2/histominute?fsym=" + text1.Text + "&tsym=" + text2.Text + "&limit=168&aggregate=1&e=CCCAGG&api_key={ba83c829e44248d3def594fb09b4290c67032502fafa324f030c2fb9390a95f1}");
            
            label1.Content = text1.Text;
            label2.Content = text2.Text;

            this.GetDataInHour(Uri, 7);
            this.GetDataOnTime("https://min-api.cryptocompare.com/data/price?fsym=" + text1.Text + "&tsyms=BTC,USD,EUR,JPY,ETH&api_key={ba83c829e44248d3def594fb09b4290c67032502fafa324f030c2fb9390a95f1}");
        }

        private void Button1M_Click(object sender, RoutedEventArgs e)
        {
            WpfPlot.Reset();
            Uri Uri = new("https://min-api.cryptocompare.com/data/v2/histohour?fsym=" + text1.Text + "&tsym=" + text2.Text + "&limit=720&aggregate=1&e=CCCAGG&api_key={ba83c829e44248d3def594fb09b4290c67032502fafa324f030c2fb9390a95f1}");

            label1.Content = text1.Text;
            label2.Content = text2.Text;

            this.GetDataInHour(Uri, 30);
            this.GetDataOnTime("https://min-api.cryptocompare.com/data/price?fsym=" + text1.Text + "&tsyms=BTC,USD,EUR,JPY,ETH&api_key={ba83c829e44248d3def594fb09b4290c67032502fafa324f030c2fb9390a95f1}");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }


        private async void GetDataInMinute(Uri URL, int day)
        {
            HistData histo = await ChartInfoapi.GetChartInfo(URL.AbsoluteUri);
            day = -day;
            List<double> price = new();

            if (histo.Data != null)
            {
                foreach (var item in histo.Data.Data)
                {
                    price.Add(item.close);
                }
                double[] priceArray = price.ToArray();

                var plt = WpfPlot.Plot;
                DateTime today = DateTime.Now;
                DateTime startday = today.AddDays(day);
                double dailyPoints= 1440;
                var sig = plt.AddSignal(priceArray, dailyPoints);
                sig.OffsetX = startday.ToOADate();



                plt.XAxis.DateTimeFormat(true);
                plt.YAxis.Label("Price");
                plt.XAxis.Label("Date and Time");
                plt.XAxis2.Label("Coin Price");
                WpfPlot.Refresh();
            }
            else
            {
                var plt = WpfPlot.Plot;
                plt.XAxis2.Label("Data unavailable");
                WpfPlot.Refresh();
            }

        }

        private async void GetDataInHour(Uri URL, int days)
        {
            HistData histo = await ChartInfoapi.GetChartInfo(URL.AbsoluteUri);
            days = -days;

            List<double> price = new();

            if (histo.Data != null)
            {
                foreach (var item in histo.Data.Data)
                {
                    price.Add(item.close);
                }
                double[] priceArray = price.ToArray();

                var plt = WpfPlot.Plot;
                DateTime today = DateTime.Now;
                DateTime startday = today.AddDays(days);
                double dailyPoints = 24;
                var sig = plt.AddSignal(priceArray, dailyPoints);
                sig.OffsetX = startday.ToOADate();



                plt.XAxis.DateTimeFormat(true);
                plt.YAxis.Label("Price");
                plt.XAxis.Label("Time");
                plt.XAxis2.Label("Coin Price");
                WpfPlot.Refresh();
            }
            else
            {
                var plt = WpfPlot.Plot;
                plt.XAxis2.Label("Data unavailable");
                WpfPlot.Refresh();
            }
        }

        private async void GetDataOnTime(string path)
        {

            CoinPrices currentPrices = await Pricesapi.GetProductAsync(path);
            BTCPrice.Content = currentPrices.BTC.ToString();
            USDPrice.Content = currentPrices.USD.ToString();
            EURPrice.Content = currentPrices.EUR.ToString();
            JPYPrice.Content = currentPrices.JPY.ToString();
            ETHPrice.Content = currentPrices.ETH.ToString();  

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow m = new();
            m.Show();
        }

        private void TradingSignals_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CoinsAvailable_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SocialDatas_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}