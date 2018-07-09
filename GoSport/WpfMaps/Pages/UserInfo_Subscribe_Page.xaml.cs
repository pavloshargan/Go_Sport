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
    /// Interaction logic for UserInfo_Subscribe_Page.xaml
    /// </summary>
    public partial class UserInfo_Subscribe_Page : Page
    {
        UserInfo_BLL_DTO user;
        BLL_Data _bll = new BLL_Data();
        public UserInfo_Subscribe_Page(UserInfo_BLL_DTO u)
        {
            InitializeComponent();
            user = u;
            //MessageBox.Show(user.FullName);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _bll.Subscibe(_bll.GetUsers().FirstOrDefault(x=>x.Firstname+" "+x.LastName==user.FullName),CurrentSession.TokenInfo);
        }
    }
}
