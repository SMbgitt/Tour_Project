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

namespace TourGuideExample
{
    /// <summary>
    /// Логика взаимодействия для CountriesCards.xaml
    /// </summary>
    public partial class CountriesCards : Window
    {
        Country country = new Country();
        public string ContinentsChange { get; set; }

        private ObservableCollection<ProbaList> _objectList;
        public ObservableCollection<ProbaList> ListBoxDataSource { get; set; }


        public CountriesCards()
        {
            InitializeComponent();

            _objectList = new ObservableCollection<ProbaList>()
            {
                 new ProbaList
                 {
                     UrlPhoto = "\\Photo\\Kazakhstan.jpg",
                     CountryName = "Kazakhstan"
                 },
                 new ProbaList
                 {
                     UrlPhoto = "\\Photo\\Kazakhstan.jpg",
                     CountryName = "Uzbekistan"
                 }

            };

            phonesList.ItemsSource = _objectList;

        }

        private void phonesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            OpenNewWindow("Kazakhstan");
        }

        private void OpenNewWindow(String countryChange)
        {
            country.CountryChange = countryChange;
            this.Close();
            country.Show();
        }
    }
}
