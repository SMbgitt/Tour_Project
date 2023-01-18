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

namespace TourGuideExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CountriesCards Continent = new CountriesCards();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSA_Click(object sender, RoutedEventArgs e)
        {
            OpenNewWindow("SA");
        }

        private void btnNA_Click(object sender, RoutedEventArgs e)
        {
            OpenNewWindow("NA");
        }

        private void btnEU_Click(object sender, RoutedEventArgs e)
        {
            OpenNewWindow("EU");
        }

        private void btnSEA_Click(object sender, RoutedEventArgs e)
        {
            OpenNewWindow("SEA");
        }

        private void OpenNewWindow(String continentsChange)
        {
            Continent.ContinentsChange = continentsChange;
            this.Close();
            Continent.Show();
        }
    }
}
