using Microsoft.Maps.MapControl.WPF;
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
    /// Interaction logic for Page_Activities.xaml
    /// </summary>
    public partial class Page_Activities : Page
    {
        private BLL_Data _bll = new BLL_Data();

        public Page_Activities()
        {
            
            InitializeComponent();
            Sport_ComboBox.ItemsSource = _bll.GetActivityTypes();
            
        }
        private void MyMap_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Activity_BLL_DTO a in _bll.GetActivities())
            {
                Pushpin pushpin = new Pushpin();
                //pushpin.Tag=a
                #region Context Menu
                ContextMenu contextMenu = new ContextMenu();
                MenuItem menuItem = new MenuItem();
                menuItem.Header = "Show Route";
                menuItem.Click += MenuItem_Click1;
                contextMenu.Items.Add(menuItem);

                menuItem = new MenuItem();
                menuItem.Header = "Show Participants";
                menuItem.Click += MenuItem_Click2;
                contextMenu.Items.Add(menuItem);
                #endregion

                pushpin.ContextMenu = contextMenu;

               
                Point_BLL_DTO point = a.Route.Points.First();
                pushpin.Location = new Location((double)point.Latitude, (double)point.Longitude);

                MyMap.Children.Add(pushpin);
            }

        }

        private void MenuItem_Click2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("2");
        }
        private void MenuItem_Click1(object sender, RoutedEventArgs e)
        {
            

        }



    }
}
