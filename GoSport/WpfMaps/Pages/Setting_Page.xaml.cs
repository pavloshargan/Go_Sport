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
using WpfMaps.ServiceReference1;
namespace WpfMaps
{
    /// <summary>
    /// Interaction logic for Setting_Page.xaml
    /// </summary>
    public partial class Setting_Page : Page
    {
        ServiceClient service = new ServiceClient();
        public Setting_Page()
        {
            InitializeComponent();
            CountryBox.ItemsSource = service.GetListCountries();
            txtFirstName.Text = CurrentSession.TokenInfo.Session.Firstname;
            txtLastName.Text = CurrentSession.TokenInfo.Session.LastName;
            txtLogin.Text = CurrentSession.TokenInfo.Session.Login;
            txtPhone.Text = CurrentSession.TokenInfo.Session.Phone;
            txtEmail.Text = CurrentSession.TokenInfo.Session.Email;

            CountryBox.SelectedItem = CurrentSession.TokenInfo.Session.City.CountryInfo;


        }
    }
}
