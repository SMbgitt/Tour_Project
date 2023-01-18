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

namespace TourGuideExample
{
    /// <summary>
    /// Логика взаимодействия для Country.xaml
    /// </summary>
    public partial class Country : Window
    {
        public string CountryChange { get; set; }

        public Country()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(CountryChange);
        }

        private void ListBoxMouseDown(object sender, MouseButtonEventArgs e)
        {
            var listBox = (ListBox)sender;
            listBox.SelectedItems.Clear();
        }
    }
}
