using System;
using System.Windows;
using System.Windows.Controls;
using TradingFinalProject.AllDataInfo;
using TradingFinalProject.Apicalls;

namespace TradingFinalProject
{
    /// <summary>
    /// Logique d'interaction pour TradingSignals.xaml
    /// </summary>
    public partial class TradingSignals : Page
    {
        public TradingSignals()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Uri Uri = new("https://min-api.cryptocompare.com");
            Uri WebPath = new(Uri, "/data/tradingsignals/intotheblock/latest");
            Uri FinalPath = new(WebPath, ("?fsym=" + ASSET.Text + "&api_key={ba83c829e44248d3def594fb09b4290c67032502fafa324f030c2fb9390a95f1}"));
            this.GetTradingData(FinalPath);
        }

        private void Chart_Click(object sender, RoutedEventArgs e)
        {
            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow m = new();
            m.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Info info = new();
            info.Show();
        }

        private async void GetTradingData(Uri URL)
        {

            TradingSignalData signal =  await Tradingsignalapi.GetTradingSignal(URL.AbsoluteUri);

            if ((signal.Data.inOutVar != null) | (signal.Data.largetxsVar != null) | (signal.Data.addressesNetGrowth != null) | (signal.Data.concentrationVar != null))
            {
                sentiment1.Content = signal.Data.inOutVar.sentiment;
                sentiment2.Content = signal.Data.largetxsVar.sentiment;
                sentiment3.Content = signal.Data.addressesNetGrowth.sentiment;
                sentiment4.Content = signal.Data.concentrationVar.sentiment;  
            }
            else
            {
                sentiment1.Content = "Data unavailable for the moment";
                sentiment2.Content = "Data unavailable for the moment";
                sentiment3.Content = "Data unavailable for the moment";
                sentiment4.Content = "Data unavailable for the moment";
            }

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
