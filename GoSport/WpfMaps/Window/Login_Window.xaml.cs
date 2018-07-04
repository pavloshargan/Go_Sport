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
    /// Interaction logic for Login_Window.xaml
    /// </summary>
    public partial class Login_Window : Window
    {
        ServiceClient service = new ServiceClient();
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
            CurrentSession.TokenInfo = service.Authentification(Emailbox.Text, Passbox.Password); 
           

            Main_Window main = new Main_Window();
            main.Show(); this.Close();
        }
        
        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SignUp_Window window = new SignUp_Window(null,null);
            window.Show();this.Close();

        }


    }
}
