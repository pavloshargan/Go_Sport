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
            if (String.IsNullOrEmpty(txtFirstName.Text) || String.IsNullOrEmpty(txtLastName.Text) || String.IsNullOrEmpty(txtEmail.Text) ||
                String.IsNullOrEmpty(txtLogin.Text) || String.IsNullOrEmpty(txtPhone.Text)||CitiesBox.SelectedItem==null||CountriesBox.SelectedItem==null)
            {
                MessageBox.Show("Please input all info");
            }
            else
            {
                UserInfo new_user = new UserInfo();
                new_user.Firstname = txtFirstName.Text;
                new_user.LastName = txtLastName.Text;
                new_user.Email = txtEmail.Text;
                new_user.Login = txtLogin.Text;
                new_user.Phone = txtPhone.Text;
                new_user.City = new CityInfo() { Name = (CitiesBox.SelectedItem as CityInfo).Name };
                try
                {
                    service.SignUp(new_user, txtPassword.Password);
                }
                catch (FaultException<IncorrectInputData> ex)
                {
                    MessageBox.Show(ex.Detail.Message);
                    return;
                }
                try
                {
                    service.SendCode(new_user.Email);
                    ConfirmEmail_Window window = new ConfirmEmail_Window(new_user, txtPassword.Password);
                    window.Show();
                    this.Close();
                }
                catch(FaultException<IncorrectInputData> ex)
                {
                    MessageBox.Show(ex.Detail.Message);
                }     
            }
        }
        private void CountriesBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CitiesBox.ItemsSource = (CountriesBox.SelectedItem as CountryInfo).CityInfos;
        }
    }
}
