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
    /// Interaction logic for Search_Page.xaml
    /// </summary>
    public partial class Search_Page : Page
    {
        Main_Window win_main;
        BLL_Data _bll = new BLL_Data();
        public Search_Page(Main_Window main)
        {
            InitializeComponent();
            win_main = main;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Add_Users_ListView.ItemsSource = _bll.GetUserInfo();
            foreach(UserInfo_BLL_DTO u in _bll.GetUserInfo())
            {
               // MessageBox.Show(u.Followers.Count().ToString());
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show("sd"+ ((((sender  as ListViewItem).Parent as ListView).DataContext as UserInfo_BLL_DTO).FullName));
           

        }



        private void Add_Users_ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // MessageBox.Show("2");
           

            ListView listView = sender as ListView;
            var track = (UserInfo_BLL_DTO)listView.SelectedItem;
            win_main.frmMain_win.Content = new UserInfo_Subscribe_Page(track);
        }
    }
}
