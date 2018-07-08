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
using BLL;
using BLL.BLL_DTO;
namespace WpfMaps
{
    /// <summary>
    /// Interaction logic for SignUp_Window.xaml
    /// </summary>
    public partial class SignUp_Window : Window
    {
        private BLL_Data _bll = new BLL_Data();
        public SignUp_Window(User_BLL_DTO user, string password)
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
            CountriesBox.ItemsSource = _bll.GetCountries();
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
                if (txtPassword.Password != txtConfirmPassBox.Password)
                {
                    MessageBox.Show("Passwords are different!");
                }
                else
                {
                    User_BLL_DTO new_user = new User_BLL_DTO();
                    new_user.Firstname = txtFirstName.Text;
                    new_user.LastName = txtLastName.Text;
                    new_user.Email = txtEmail.Text;
                    new_user.Login = txtLogin.Text;
                    new_user.Phone = txtPhone.Text;
                    new_user.City = new City_BLL_DTO() { Name = (CitiesBox.SelectedItem as City_BLL_DTO).Name };
                    try
                    {
                        _bll.SignUp(txtFirstName.Text, txtLastName.Text, txtLogin.Text, txtEmail.Text, txtPhone.Text,txtPassword.Password, (CitiesBox.SelectedItem as City_BLL_DTO).Name, (CitiesBox.SelectedItem as City_BLL_DTO).Country.Name);
                    }
                    catch (FaultException<IncorrectInputData> ex)
                    {
                        MessageBox.Show(ex.Detail.Message);
                        return;
                    }
                    try
                    {
                        _bll.SendCode(new_user.Email);
                        ConfirmEmail_Window window = new ConfirmEmail_Window(new_user, txtPassword.Password);
                        window.Show();
                        this.Close();
                    }
                    catch (FaultException<IncorrectInputData> ex)
                    {
                        MessageBox.Show(ex.Detail.Message);
                    }
                }
            }
        }
        private void CountriesBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CitiesBox.ItemsSource = (CountriesBox.SelectedItem as Country_BLL_DTO).Cities;
        }

    }
}
