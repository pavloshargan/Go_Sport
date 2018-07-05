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
using WpfMaps.ServiceReference1;
using Microsoft.Maps.MapControl.WPF;
using System.ServiceModel;

namespace WpfMaps
{
    /// <summary>
    /// Interaction logic for Add_Activity_Page.xaml
    /// </summary>
    public partial class Add_Activity_Page : Page
    {
        ServiceClient service = new ServiceClient();
        Map_Page map_Page = new Map_Page();

        public Add_Activity_Page()
        {
            InitializeComponent();

            Sport_ComboBox.ItemsSource = service.GetActivityTypes();
            Frame_Map.Content = map_Page;
            CityBox.ItemsSource = service.GetListCities();
        }
        private void Add_Activity_Click(object sender, RoutedEventArgs e)
        {
            ActivityInfo activity = new ActivityInfo();
            activity.Date = DateBox.SelectedDate.Value;
            activity.Date = TimeBox.SelectedTime.Value;
            activity.Type = Sport_ComboBox.SelectedItem.ToString();

            List<PointInfo> points = new List<PointInfo>();
            try
            {
                points.Add(new PointInfo()
                {
                    Latitude = (decimal)map_Page.Get_Start_DragPin.Location.Latitude,
                    Longitude = (decimal)map_Page.Get_Start_DragPin.Location.Longitude
                });
                for (int i = 0; i < map_Page.Get_Other_DragPins.Count; i++)
                {
                    points.Add(new PointInfo()
                    {
                        Latitude = (decimal)map_Page.Get_Other_DragPins[i].Location.Latitude,
                        Longitude = (decimal)map_Page.Get_Other_DragPins[i].Location.Longitude
                    });
                }
                points.Add(new PointInfo()
                {
                    Latitude = (decimal)map_Page.Get_End_DragPin.Location.Latitude,
                    Longitude = (decimal)map_Page.Get_End_DragPin.Location.Longitude
                });

                RouteInfo route = new RouteInfo();
                route.Points = points.ToArray();
          
                route.City = (CityBox.SelectedItem as CityInfo).Name;
      
                activity.Route = route;

                MessageBox.Show(activity.Date.ToString() + "  " + activity.Type);
                
                service.CreateActivity(activity, CurrentSession.TokenInfo);

            }
            catch (FaultException<IncorrectInputData> ex)
            {
                MessageBox.Show(ex.Detail.Message);
                //throw;
            }




        }


    }
}
