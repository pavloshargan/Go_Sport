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

namespace WpfMaps
{
    /// <summary>
    /// Interaction logic for UserInfo_Page.xaml
    /// </summary>
    public partial class UserInfo_Page : Page
    {
        List<Kartinki> kartinkis = new List<Kartinki>();
        public UserInfo_Page()
        {
            InitializeComponent();
            kartinkis.Add(new Kartinki() { Path = @"\Icons\olimpycs_38_icon-icons.com_68602.png", CountLikes = 20 });
            kartinkis.Add(new Kartinki() { Path = @"\Icons\olimpycs_38_icon-icons.com_68602.png", CountLikes = 200 });
            kartinkis.Add(new Kartinki() { Path = @"\Icons\olimpycs_38_icon-icons.com_68602.png", CountLikes = 2000 });
            kartinkis.Add(new Kartinki() { Path = @"\Icons\olimpycs_38_icon-icons.com_68602.png", CountLikes = 20000 });
            Add_MyPost_ListView.ItemsSource = kartinkis;


            FirstNameBox.Text = CurrentSession.TokenInfo.Session.Firstname;
            LastNameBox.Text = CurrentSession.TokenInfo.Session.LastName;
            EmailBox.Text = CurrentSession.TokenInfo.Session.Email;
            PhoneBox.Text = CurrentSession.TokenInfo.Session.Phone;
            LoginBox.Text = CurrentSession.TokenInfo.Session.Login;
        }
    }
  
}
