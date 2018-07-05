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

namespace WpfMaps
{
    /// <summary>
    /// Interaction logic for Map_Page.xaml
    /// </summary>
    public partial class Map_Page : Page
    {
        public DragPin Get_Start_DragPin { get;  set; }
        public DragPin Get_End_DragPin { get;  set; }
        public List<DragPin> Get_Other_DragPins { get; set; } = new List<DragPin>();



        private List<MapPolyline> polylines = new List<MapPolyline>();
        private MapLayer RouteLayer;
        private string SessionKey;

        Location pinLocation;
        public Map_Page()
        {
            InitializeComponent();
            MyMap.Loaded += MyMap_Loaded;
        }
        private void MyMap_Loaded(object sender, RoutedEventArgs e)
        {
            //Get a session key from the Bing Maps WPF control.
            MyMap.CredentialsProvider.GetCredentials((c) =>
            {
                SessionKey = c.ApplicationId;

                //Create a layer for Route data.
                RouteLayer = new MapLayer();
                MyMap.Children.Add(RouteLayer);
            });
        }
        public async void UpdateRoute(Location loc, DragPin fisrt, DragPin sec)
        {
            RouteLayer.Children.Clear();
            polylines.Clear();
            //var startCoord = LocationToCoordinate(fisrt.Location);
            //var endCoord = LocationToCoordinate(sec.Location);
            BingMapsRESTToolkit.Coordinate startCoord = null;
            BingMapsRESTToolkit.Coordinate endCoord = null;


            if (Get_Other_DragPins.Count == 0)
            {
                // MessageBox.Show("зайшло коли ліст нуль");
                startCoord = LocationToCoordinate(Get_Start_DragPin.Location);
                endCoord = LocationToCoordinate(Get_End_DragPin.Location);

                #region
                var response = await BingMapsRESTToolkit.ServiceManager.GetResponseAsync(new BingMapsRESTToolkit.RouteRequest()
                {
                    Waypoints = new List<BingMapsRESTToolkit.SimpleWaypoint>()
                {
                    new BingMapsRESTToolkit.SimpleWaypoint(startCoord),
                    new BingMapsRESTToolkit.SimpleWaypoint(endCoord)
                },
                    BingMapsKey = SessionKey,
                    RouteOptions = new BingMapsRESTToolkit.RouteOptions()
                    {
                        RouteAttributes = new List<BingMapsRESTToolkit.RouteAttributeType>
                    {
                        //Be sure to return the route path information so that we can draw the route line.
                        BingMapsRESTToolkit.RouteAttributeType.RoutePath
                    }
                    }
                });

                if (response != null &&
                    response.ResourceSets != null &&
                    response.ResourceSets.Length > 0 &&
                    response.ResourceSets[0].Resources != null &&
                    response.ResourceSets[0].Resources.Length > 0)
                {
                    var route = response.ResourceSets[0].Resources[0] as BingMapsRESTToolkit.Route;

                    //Generate a Polyline from the route path information.
                    var locs = new LocationCollection();

                    for (var i = 0; i < route.RoutePath.Line.Coordinates.Length; i++)
                    {
                        locs.Add(new Location(route.RoutePath.Line.Coordinates[i][0], route.RoutePath.Line.Coordinates[i][1]));
                    }

                    var routeLine = new MapPolyline()
                    {
                        Locations = locs,
                        Stroke = new SolidColorBrush(Colors.Blue),
                        StrokeThickness = 3
                    };

                    polylines.Add(routeLine);

                    foreach (MapPolyline a in polylines)
                    {
                        RouteLayer.Children.Add(a);
                    }
                }
                #endregion
            }
            else
            {
                // MessageBox.Show("зайшло коли ліст не нуль");
                for (int j = 0; j <= Get_Other_DragPins.Count; j++)
                {

                    if (j == 0)
                    {
                        // MessageBox.Show("зайшло будує від першого до того шо додав" + "j=" + j);
                        startCoord = LocationToCoordinate(Get_Start_DragPin.Location);
                        endCoord = LocationToCoordinate(Get_Other_DragPins[0].Location);
                    }
                    else if (j == Get_Other_DragPins.Count)
                    {
                        //MessageBox.Show("зайшло будує від того шо додав до останнього");
                        startCoord = LocationToCoordinate(Get_Other_DragPins[Get_Other_DragPins.Count - 1].Location);
                        endCoord = LocationToCoordinate(Get_End_DragPin.Location);
                    }
                    if (j != 0 && j != Get_Other_DragPins.Count)
                    {
                        startCoord = LocationToCoordinate(Get_Other_DragPins[j - 1].Location);
                        endCoord = LocationToCoordinate(Get_Other_DragPins[j].Location);
                    }

                    #region  draw
                    var response = await BingMapsRESTToolkit.ServiceManager.GetResponseAsync(new BingMapsRESTToolkit.RouteRequest()
                    {
                        Waypoints = new List<BingMapsRESTToolkit.SimpleWaypoint>()
                {
                    new BingMapsRESTToolkit.SimpleWaypoint(startCoord),
                    new BingMapsRESTToolkit.SimpleWaypoint(endCoord)
                },
                        BingMapsKey = SessionKey,
                        RouteOptions = new BingMapsRESTToolkit.RouteOptions()
                        {
                            RouteAttributes = new List<BingMapsRESTToolkit.RouteAttributeType>
                    {
                        //Be sure to return the route path information so that we can draw the route line.
                        BingMapsRESTToolkit.RouteAttributeType.RoutePath
                    }
                        }
                    });

                    if (response != null &&
                        response.ResourceSets != null &&
                        response.ResourceSets.Length > 0 &&
                        response.ResourceSets[0].Resources != null &&
                        response.ResourceSets[0].Resources.Length > 0)
                    {
                        var route = response.ResourceSets[0].Resources[0] as BingMapsRESTToolkit.Route;

                        //Generate a Polyline from the route path information.
                        var locs = new LocationCollection();

                        for (var i = 0; i < route.RoutePath.Line.Coordinates.Length; i++)
                        {
                            locs.Add(new Location(route.RoutePath.Line.Coordinates[i][0], route.RoutePath.Line.Coordinates[i][1]));
                        }

                        var routeLine = new MapPolyline()
                        {
                            Locations = locs,
                            Stroke = new SolidColorBrush(Colors.Blue),
                            StrokeThickness = 3
                        };
                        polylines.Add(routeLine);
                        //MessageBox.Show(polylines.Count.ToString());

                        // RouteLayer.Children.Add(polylines[0]);
                    }
                    /*foreach (MapPolyline a in polylines)
                    {
                        RouteLayer.Children.Add(a);
                       // MessageBox.Show(polylines.Count.ToString());
                    }*/

                    #endregion
                }
                try
                {
                    foreach (MapPolyline a in polylines)
                    {
                        RouteLayer.Children.Add(a);
                        // MessageBox.Show(polylines.Count.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }

            //Calculate a route between the start and end pushpin.

        }


        #region
        private BingMapsRESTToolkit.Coordinate LocationToCoordinate(Location loc)
        {
            return new BingMapsRESTToolkit.Coordinate(loc.Latitude, loc.Longitude);
        }

        private BitmapImage GetImageSource(string imageSource)
        {
            var icon = new BitmapImage();
            icon.BeginInit();
            icon.UriSource = new Uri(imageSource, UriKind.Relative);
            icon.EndInit();

            return icon;
        }
        #endregion

        //click coordinate 
        private void MyMap_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            e.Handled = true;
            Point mousePosition = new Point();
            mousePosition.X = e.GetPosition(this).X;
            mousePosition.Y = e.GetPosition(this).Y;
            pinLocation = MyMap.ViewportPointToLocation(mousePosition);
        }

        //click contextmenu from
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(pinLocation.Latitude.ToString() + "    " + pinLocation.Longitude.ToString());
            //Pushpin pushpin = new Pushpin() { Location=pinLocation};
            //MyMap.Children.Add(pushpin);

            Get_Start_DragPin = new DragPin(this.MyMap) { Location = pinLocation, ImageSource = GetImageSource("/Icons/red_pin.png") };
            Get_Start_DragPin.DragEnd += UpdateRoute;
            //StartPin.MouseLeftButtonUp += StartPin_MouseLeftButtonUp;


            MyMap.Children.Add(Get_Start_DragPin);


        }
        /* private void StartPin_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
         {
             e.Handled = true;
             Point mousePosition = new Point();
             mousePosition.X = e.GetPosition(this).X;
             mousePosition.Y = e.GetPosition(this).Y;
             Location pinL = MyMap.ViewportPointToLocation(mousePosition);
             MessageBox.Show(pinL.Longitude + " " + pinL.Latitude);
         }*/

        //click contextmenu to
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Get_End_DragPin = new DragPin(this.MyMap) { Location = pinLocation, ImageSource = GetImageSource("/Icons/red_pin.png") };
            Get_End_DragPin.DragEnd += UpdateRoute;
            MyMap.Children.Add(Get_End_DragPin);
            UpdateRoute(null, null, null);
        }
        //click contextmenu add
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            DragPin pin = new DragPin(this.MyMap) { Location = pinLocation, ImageSource = GetImageSource("/Icons/green_pin.png") };
            pin.DragEnd += UpdateRoute;
            MyMap.Children.Add(pin);
            Get_Other_DragPins.Add(pin);
            UpdateRoute(null, null, null);
        }


       
    }
}
