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
using BLL;
using BLL.BLL_DTO;
namespace WpfMaps
{
    /// <summary>
    /// Interaction logic for Setting_Page.xaml
    /// </summary>
    public partial class Setting_Page : Page
    {
        private BLL_Data _bll = new BLL_Data();
        public Setting_Page()
        {
            InitializeComponent();
            CountryBox.ItemsSource = _bll.GetCountries();
            txtFirstName.Text = CurrentSession.TokenInfo.User.Firstname;
            txtLastName.Text = CurrentSession.TokenInfo.User.LastName;
            txtLogin.Text = CurrentSession.TokenInfo.User.Login;
            txtPhone.Text = CurrentSession.TokenInfo.User.Phone;
            txtEmail.Text = CurrentSession.TokenInfo.User.Email;

            CountryBox.SelectedItem = CurrentSession.TokenInfo.User.City.Country;


        }
    }
}
