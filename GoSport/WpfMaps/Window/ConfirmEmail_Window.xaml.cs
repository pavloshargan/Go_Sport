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
    /// Interaction logic for ConfirmEmail_Window.xaml
    /// </summary>
    public partial class ConfirmEmail_Window : Window
    {
        private UserInfo CurrentUser;
        private string Password;
        ServiceClient client = new ServiceClient();
        public ConfirmEmail_Window(UserInfo user, string password)
        {
            InitializeComponent();
            CurrentUser = user;
            Password = password;
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            new SignUp_Window(CurrentUser, Password).Show();
            this.Close();
        }

        private void Button_Submit_Click(object sender, RoutedEventArgs e)
        {
            client.ConfirmEmail(CurrentUser.Email, CodeBox.Text);
        }

        
    }
}
