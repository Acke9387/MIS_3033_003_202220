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
using System.Xml.Linq;

namespace MyFirstWPFApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {

            TextBox x = new TextBox();
            string name = txtName.Text;

            if (string.IsNullOrWhiteSpace(name) == false)
            {
                MessageBox.Show($"Hello {name}!");
            }
            else
            {
                MessageBox.Show("Please enter your name then press the button");
            }

        }

    }
}
