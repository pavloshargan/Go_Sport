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
    /// Interaction logic for Login_Window.xaml
    /// </summary>
    public partial class Login_Window : Window
    {
        private BLL_Data _bll = new BLL_Data();
        public Login_Window()
        {
            InitializeComponent();
        }
        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
     
        private void Submit_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string key = _bll.SignIn(txtEmail.Text, txtPassword.Password);
                CurrentSession.TokenInfo = _bll.GetTokenByKey(key);
            }
            catch (FaultException<IncorrectInputData> ex)
            {
                MessageBox.Show(ex.Detail.Message);
                return;
            }
            Main_Window main = new Main_Window();
            main.Show();
            this.Close();
        }
        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SignUp_Window window = new SignUp_Window(null,null);
            window.Show();this.Close();

        }

        private void Forgot_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
