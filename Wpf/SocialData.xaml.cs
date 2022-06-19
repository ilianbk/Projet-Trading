using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TradingFinalProject.AllDataInfo;
using TradingFinalProject.Apicalls;

namespace TradingFinalProject.Wpf
{
    /// <summary>
    /// Logique d'interaction pour SocialData.xaml
    /// </summary>
    public partial class SocialData : Page
    {
        public SocialData()
        {
            InitializeComponent();
          
        }
        private async void GetSocial(string URL)
        {
            SocialDataa social = await Socialapi.GetSocial(URL);

            if ((social.Data.Facebook != null) | (social.Data.Reddit != null) | (social.Data.Twitter != null) | (social.Data.CryptoCompare != null))
            {
                Point.Text = social.Data.CryptoCompare.Points.ToString();
                Follower.Text = social.Data.CryptoCompare.Followers.ToString();
                Post.Text = social.Data.CryptoCompare.Posts.ToString();
                Comment.Text = social.Data.CryptoCompare.Comments.ToString();

                Point2.Text = social.Data.Twitter.Points.ToString();
                Follower2.Text = social.Data.Twitter.followers.ToString();
                Post2.Text = social.Data.Twitter.account_creation.ToString();
                Comment2.Text = social.Data.Twitter.favourites.ToString();

                Point3.Text = social.Data.Reddit.Points.ToString();
                Follower3.Text = social.Data.Reddit.active_users.ToString();
                Post3.Text = social.Data.Reddit.community_creation.ToString();
                Comment3.Text = social.Data.Reddit.subscribers.ToString();

                Point4.Text = social.Data.Facebook.Points.ToString();
                Follower4.Text = social.Data.Facebook.talking_about.ToString();
                Post4.Text = social.Data.Facebook.likes.ToString();
            }
            else
            {
                MessageBox.Show("Data unavailable or incorrect input !\n", "Error in input");
            }
             
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TradingSignals_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CoinsAvailable_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.GetSocial("https://min-api.cryptocompare.com/data/social/coin/latest?coinId=" + Coin.Text + "&api_key=ba83c829e44248d3def594fb09b4290c67032502fafa324f030c2fb9390a95f1");
        }

        private void Name3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Follower3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Follower2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow m = new();
            m.Show();
        }

        private void SocialDatas_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
