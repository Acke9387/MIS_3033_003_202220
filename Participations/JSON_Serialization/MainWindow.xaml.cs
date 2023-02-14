using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace JSON_Serialization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Game> Games = new List<Game>();
        public MainWindow()
        {
            InitializeComponent();

            string[] lines = File.ReadAllLines("all_games.csv");

            foreach (string line in lines.Skip(1))
            {
                Game g = new Game(line);
                Games.Add(g);

                if (cboPlatforms.Items.Contains(g.platform) == false)
                {
                    cboPlatforms.Items.Add(g.platform);
                }
                lstData.Items.Add(g);
            }

        }

        private void cboPlatforms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedPlatform = cboPlatforms.SelectedItem.ToString();
            lstData.Items.Clear();

            foreach (var game in Games)
            {
                if (game.platform == selectedPlatform)
                {
                    lstData.Items.Add(game);
                }
            }
        }

        private void btnSaveData_Click(object sender, RoutedEventArgs e)
        {
            string jsonOutput = JsonConvert.SerializeObject(lstData.Items);

            //List<Game> games = JsonConvert.DeserializeObject<List<Game>>(jsonOutput);

            File.WriteAllText($"{cboPlatforms.SelectedItem.ToString()}_Games.json", jsonOutput);
            MessageBox.Show("Successfully Saved Data"); 
        }
    }
}
