using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace JSON_GameOfThroneQuote
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GOTAPI api = GetQuote();
            lblQuote.Content = $"{api.sentence} - {api.character.name}";
        }

        private GOTAPI GetQuote()
        {
            GOTAPI api;


            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync("https://api.gameofthronesquotes.xyz/v1/random").Result;

                api = JsonConvert.DeserializeObject<GOTAPI>(json);

            }

            return api;
           
        }

        private void btnGetQuote_Click(object sender, RoutedEventArgs e)
        {
            GOTAPI api =  GetQuote();
            lblQuote.Content = $"{api.sentence} - {api.character.name}";

            QuoteWindow quote = new QuoteWindow();
            quote.SetData(api);

            quote.ShowDialog();

        }
    }
}
