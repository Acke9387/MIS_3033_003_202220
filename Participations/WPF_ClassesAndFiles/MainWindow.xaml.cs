using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
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
using static System.Net.Mime.MediaTypeNames;

namespace WPF_ClassesAndFiles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string[] contentsOfFile = File.ReadAllLines("Toys.csv");

            //contentsOfFile[0] = "Manufacturer,Name,Price,Image";

            foreach (string line in contentsOfFile.Skip(1))
            {
                string[] piecesOfLine = line.Split(",");
                Toy t = new Toy()
                {
                    Manufacturer = piecesOfLine[0],
                    Name = piecesOfLine[1],
                    Price = Convert.ToDouble(piecesOfLine[2]),
                    Image = piecesOfLine[3]
                };

                lstToys.Items.Add(t);
            }
        }

        private void btnAddToy_Click(object sender, RoutedEventArgs e)
        {

            double price;

            if (double.TryParse(txtPrice.Text, out price) == false)
            {
                MessageBox.Show("Please enter a double value for the price");
                return;
            }

            Toy t = new Toy()
            {
                Manufacturer = txtManufacturer.Text,
                Name = txtName.Text,
                Price = price,
                Image = txtImage.Text
            };

            lstToys.Items.Add(t);

            txtPrice.Clear();
            txtManufacturer.Clear();
            txtName.Clear();
            txtImage.Clear();
            txtManufacturer.Focus();
        }

        private void lstToys_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Toy selectedToy = (Toy)lstToys.SelectedItem;

            imgToy.Source = new BitmapImage(new Uri(selectedToy.Image));

            MessageBox.Show($"{selectedToy.Name} can be found on {selectedToy.GetAisle()}");

            //var uri = new Uri(selectedToy.Image);
            //var img = new BitmapImage(uri);
            //imgToy.Source = img;

        }
    }
}
