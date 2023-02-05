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

namespace JSON_RickAndMorty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string json;

            using (HttpClient client = new HttpClient())
            {
                json = client.GetStringAsync("https://rickandmortyapi.com/api/character").Result;
            }

            RickAndMortyAPI api = JsonConvert.DeserializeObject<RickAndMortyAPI>(json);


            foreach (Character character in api.results.OrderBy(x => x.name))
            {
                cboCharacters.Items.Add(character);
            }
        }

        private void btnGetInfo_Click(object sender, RoutedEventArgs e)
        {
            UpdateCharacterInformation();
        }

        private void UpdateCharacterInformation()
        {
            Character selectedCharacter = (Character)cboCharacters.SelectedItem;

            imgCharacter.Source = new BitmapImage(new Uri(selectedCharacter.image));
            txtName.Text = selectedCharacter.name;
        }

        private void cboCharacters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateCharacterInformation();
        }
    }
}
