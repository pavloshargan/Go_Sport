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
using WpfMaps.ServiceReference1;

namespace WpfMaps
{
    /// <summary>
    /// Interaction logic for SignUp_Window.xaml
    /// </summary>
    public partial class SignUp_Window : Window
    {
        ServiceClient service = new ServiceClient();
        public SignUp_Window()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            
            Login_Window window = new Login_Window();
            window.Show();this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CountriesBox.ItemsSource = service.GetListCountries();
            CitiesBox.ItemsSource = service.GetListCities();
        }

        private void Button_Click_Submit(object sender, RoutedEventArgs e)
        {
            ConfirmEmail_Window window = new ConfirmEmail_Window();
            window.ShowDialog();



        }

        private void CountriesBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CitiesBox.ItemsSource = (CountriesBox.SelectedItem as CountryInfo).CityInfos;
        }
    }
}
