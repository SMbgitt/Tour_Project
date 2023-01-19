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
using System.Windows.Shapes;
using TourGuideExample.BLL;

namespace TourGuideExample
{
    /// <summary>
    /// Логика взаимодействия для Country.xaml
    /// </summary>
    public partial class Country : Window
    {
        public string CountryChange { get; set; }
        RequestInfo countryInfo = new RequestInfo();
        CountryBase countryBase = new CountryBase();
        List<SightBase> sightBase = new List<SightBase>();
        List<FactBase> factBase = new List<FactBase>();
        List<PictureBase> pictureBase = new List<PictureBase>();

        List<CountryCurrencyBase> currencyBaseId = new List<CountryCurrencyBase>();
        List<CountryDangerous> dangerousBaseId = new List<CountryDangerous>();

        List<CurrencyBase> currencyBase = new List<CurrencyBase>();
        List<DangerBase> dangerBase = new List<DangerBase>();

        private string Sight { get; set; }
        private string Fact { get; set; }
        private string Currency { get; set; }
        private string Danger { get; set; }

        public Country()
        {
            InitializeComponent();

        }

        public void ViewCountry()
        {
            countryBase = countryInfo.GetCountryById(1);
            sightBase = countryInfo.GetSightsByCountryId(1);
            factBase = countryInfo.GetFactsByCountryId(1);

            currencyBaseId = countryInfo.GetCountryCurrencyId(1);
            dangerousBaseId = countryInfo.GetCountryDangerousId(1);

            currencyBase = countryInfo.GetCurrencyByCountryId(currencyBaseId);
            dangerBase = countryInfo.GetDangerousByCountryId(dangerousBaseId);


            foreach (SightBase sight in sightBase)
            {
                Sight += sight.Description;
                Sight += "\n";
            }

            foreach (CurrencyBase currency in currencyBase)
            {
                Currency += currency.Description;
                Currency += "\n";
            }

            foreach (DangerBase danger in dangerBase)
            {
                Danger += danger.Description;
                Danger += "\n";
            }

            foreach (FactBase fact in factBase)
            {
                Fact += fact.Description;
                Fact += "\n";
            }

            nameCountry.Text = countryBase.Name;
            descriptionInfo.Text = countryBase.Description;
            kitchenInfo.Text = countryBase.Kitchen;
            timeInfo.Text = countryBase.TimeZone;
            weatherInfo.Text = countryBase.Weather;
            attractionInfo.Text = Sight;
            moneyInfo.Text = Currency;
            dangerInfo.Text = Danger;
            factsInfo.Text = Fact;
        }

        private void ListBoxMouseDown(object sender, MouseButtonEventArgs e)
        {
            var listBox = (ListBox)sender;
            listBox.SelectedItems.Clear();
        }
    }
}
