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

using Microsoft.Maps.MapControl.WPF;
using System.ServiceModel;
using BLL;
using BLL.BLL_DTO;
namespace WpfMaps
{
    /// <summary>
    /// Interaction logic for Add_Activity_Page.xaml
    /// </summary>
    public partial class Add_Activity_Page : Page
    {
        //  ServiceClient service = new ServiceClient();
        Map_Page map_Page = new Map_Page();
        private BLL_Data _bll = new BLL_Data();
        public Add_Activity_Page()
        {
            InitializeComponent();

            Sport_ComboBox.ItemsSource = _bll.GetActivityTypes();
            Frame_Map.Content = map_Page;
            CityBox.ItemsSource = _bll.GetCities();
        }



        private void Add_Activity_Click(object sender, RoutedEventArgs e)
        {
            Activity_BLL_DTO activity = new Activity_BLL_DTO();
            activity.Date = DateBox.SelectedDate.Value;
            activity.Date = TimeBox.SelectedTime.Value;
            activity.Type = (Sport_ComboBox.SelectedItem as ActivityType_BLL_DTO);

            List<Point_BLL_DTO> points = new List<Point_BLL_DTO>();

            points.Add(new Point_BLL_DTO()
            {
                Latitude = (decimal)map_Page.Get_Start_DragPin.Location.Latitude,
                Longitude = (decimal)map_Page.Get_Start_DragPin.Location.Longitude
            });
            for (int i = 0; i < map_Page.Get_Other_DragPins.Count; i++)
            {
                points.Add(new Point_BLL_DTO()
                {
                    Latitude = (decimal)map_Page.Get_Other_DragPins[i].Location.Latitude,
                    Longitude = (decimal)map_Page.Get_Other_DragPins[i].Location.Longitude
                });
            }
            points.Add(new Point_BLL_DTO()
            {
                Latitude = (decimal)map_Page.Get_End_DragPin.Location.Latitude,
                Longitude = (decimal)map_Page.Get_End_DragPin.Location.Longitude
            });

            Route_BLL_DTO route = new Route_BLL_DTO();
            route.Points = points.ToArray();

            route.City = (CityBox.SelectedItem as City_BLL_DTO);

            activity.Route = route;
            activity.Route.City = (CityBox.SelectedItem as City_BLL_DTO);

            MessageBox.Show(activity.Date.ToString() + "  " + activity.Type);

            _bll.CreateActivity(activity);

            
        }


    }
}
