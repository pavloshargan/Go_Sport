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
    /// Interaction logic for Main_Window.xaml
    /// </summary>
    public partial class Main_Window : Window
    {
        private ServiceClient service;
        private TokenInfo CurrentSession;
        public Main_Window(TokenInfo token)
        {
            InitializeComponent();
            UserName_Block.Text = CurrentSession.TokenInfo.Session.Firstname;
        }
        private void MapWithPushpins_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //e.Handled = true;
            //Point mousePosition = e.GetPosition(this);
            //Location pinLocation = myMap.ViewportPointToLocation(mousePosition);
            //Pushpin pin = new Pushpin();
            //pin.Location = pinLocation;
            //myMap.Children.Add(pin);
        }
        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void listViewItem2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Main_Frame.Content = new Page_Activities();
        }

        private void listViewItem3_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Main_Frame.Content = new Map_Page();
        }

        private void ButtonUserInfo_Click(object sender, RoutedEventArgs e)
        {
            Main_Frame.Content = new UserInfo_Page();
        }

        private void listViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Main_Frame.Content = new Home_Page();
        }

     
        private void Button_Click_AddActivity(object sender, RoutedEventArgs e)
        {
            Main_Frame.Content = new Add_Activity_Page();
        }

     
        private void Button_Setting_Click(object sender, RoutedEventArgs e)
        {
            Main_Frame.Content = new Setting_Page();
        }
    }
}
