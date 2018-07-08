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

using BLL;
using BLL.BLL_DTO;
namespace WpfMaps
{
    /// <summary>
    /// Interaction logic for ConfirmEmail_Window.xaml
    /// </summary>
    public partial class ConfirmEmail_Window : Window
    {
        private User_BLL_DTO CurrentUser;
        private string Password;
        private BLL_Data _bll = new BLL_Data();

        public ConfirmEmail_Window(User_BLL_DTO user, string password)
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
            try
            {
                bool a= _bll.ConfirmEmail(CurrentUser.Email, CodeBox.Text);
                if (a)
                {
                    MessageBox.Show("Done");
                    Login_Window window = new Login_Window();
                    window.Show();this.Close();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        
    }
}
