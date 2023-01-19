using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
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
using System.Windows.Shapes;
using TourGuideExample.BLL;

namespace TourGuideExample
{
    /// <summary>
    /// Логика взаимодействия для CountriesCards.xaml
    /// </summary>
    public partial class CountriesCards : Window
    {
        Country country = new Country();
        public ObservableCollection<ProbaList> _objectList { get; set; }

        public CountriesCards()
        {
            InitializeComponent();
        }

        public void ViewCountries()
        {
            phonesList.ItemsSource = _objectList;
        }

        private void phonesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            OpenNewWindow("1");
        }

        private void OpenNewWindow(String countryChange)
        {
            country.CountryChange = countryChange;
            this.Close();
            country.ViewCountry();
            country.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            phonesList.ItemsSource = _objectList;

        }
    }
}
