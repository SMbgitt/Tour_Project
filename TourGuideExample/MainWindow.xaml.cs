using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using TourGuideExample.BLL;

namespace TourGuideExample;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    CountriesCards Continent = new CountriesCards();

    public List<CountryBase> CountriesBase { get; set; }
    RequestInfo infoCountries = new RequestInfo();
    public ObservableCollection<ProbaList> _objectList { get; set; }


    public MainWindow()
    {
        InitializeComponent();
    }

    private void btnSA_Click(object sender, RoutedEventArgs e)
    {
        CountriesBase = infoCountries.GetCountriesListById(1);

        foreach (CountryBase countryName in CountriesBase)
        {
            _objectList = new ObservableCollection<ProbaList>()
                {
                     new ProbaList
                     {
                         UrlPhoto = "\\Photo\\Japan2.jpg",
                         CountryName = countryName.Name
                     }
                };
        }

        OpenNewWindow(_objectList);
    }

    private void btnNA_Click(object sender, RoutedEventArgs e)
    {
        CountriesBase = infoCountries.GetCountriesListById(2);

        foreach (CountryBase countryName in CountriesBase)
        {
            _objectList = new ObservableCollection<ProbaList>()
                {
                     new ProbaList
                     {
                         UrlPhoto = "\\Photo\\Japan2.jpg",
                         CountryName = countryName.Name
                     }
                };
        }

        OpenNewWindow(_objectList);
    }

    private void btnEU_Click(object sender, RoutedEventArgs e)
    {
        CountriesBase = infoCountries.GetCountriesListById(3);

        foreach (CountryBase countryName in CountriesBase)
        {
            _objectList = new ObservableCollection<ProbaList>()
                {
                     new ProbaList
                     {
                         UrlPhoto = "\\Photo\\Japan2.jpg",
                         CountryName = countryName.Name
                     }
                };
        }

        OpenNewWindow(_objectList);
    }

    private void btnSEA_Click(object sender, RoutedEventArgs e)
    {
        CountriesBase = infoCountries.GetCountriesListById(4);

        foreach (CountryBase countryName in CountriesBase)
        {
            _objectList = new ObservableCollection<ProbaList>()
                {
                     new ProbaList
                     {
                         UrlPhoto = "\\Photo\\Japan2.jpg",
                         CountryName = countryName.Name
                     }
                };
        }

        OpenNewWindow(_objectList);
    }

    private void OpenNewWindow(ObservableCollection<ProbaList> objectList)
    {
        Continent._objectList = objectList;
        this.Close();
        Continent.ViewCountries();
        Continent.Show();
    }
}
