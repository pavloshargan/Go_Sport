using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
        public SignUp_Window(UserInfo user, string password)
        {
            InitializeComponent();
            if(user!=null)
            {
                txtFirstName.Text = user.Firstname;
                txtLastName.Text = user.LastName;
                txtLogin.Text = user.Login;
                txtEmail.Text = user.Email;
                txtPhone.Text = user.Phone;
                //foreach(CountryInfo c in CountriesBox.Items)
                //{
                //    if (c.Name == user.City.CountryInfo.Name)
                //        CountriesBox.SelectedItem = c;
                //}
                //CitiesBox.ItemsSource = (CountriesBox.SelectedItem as CountryInfo).CityInfos;
                //foreach (CityInfo c in CitiesBox.Items)
                //{
                //    if(c.Name==user.City.Name)
                //    CitiesBox.SelectedItem = c;
                //}
            }
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            
            Login_Window window = new Login_Window();
            window.Show();this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CountriesBox.ItemsSource = service.GetListCountries();
            //CitiesBox.ItemsSource = service.GetListCities();
        }

        private void Button_Click_Submit(object sender, RoutedEventArgs e)
        {
            UserInfo new_user = new UserInfo();
            new_user.Firstname = txtFirstName.Text;
            new_user.LastName = txtLastName.Text;
            new_user.Email = txtEmail.Text;
            new_user.Login = txtLogin.Text;
            new_user.Phone = txtPhone.Text;
            //CityInfo selected_city = (CitiesBox.SelectedItem as CityInfo);
          //  new_user.City = service.GetListCities().FirstOrDefault(x=>x.Name==selected_city.Name&&x.CountryInfo.Name==selected_city.CountryInfo.Name);
            try
            {
                service.SignUp(new_user, txtPassword.Password);
            }
            catch (FaultException<IncorrectInputData> ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            service.SendCode(new_user.Email);
            ConfirmEmail_Window window = new ConfirmEmail_Window(new_user, txtPassword.Password);
            window.Show();
            this.Close();
        }

        private void CountriesBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CitiesBox.ItemsSource = (CountriesBox.SelectedItem as CountryInfo).CityInfos;
        }
    }
}
