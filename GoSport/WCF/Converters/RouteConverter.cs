using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace WCF
{
    public static class RouteConverter
    {
        public static Route ToRoute(RouteInfo route)
        {
            Route rez = new Route();
            using (DataModel context = new DataModel())
            {
                rez.City = CityConverter.ToCity(route.City);
                foreach(PointInfo p in route.Points)
                {
                    rez.Points.Add(PointConverter.ToPoint(p));
                }
            }
            return rez;
        }
        public static RouteInfo ToRouteInfo(Route route)
        {
            RouteInfo rez = new RouteInfo();
            rez.City = CityConverter.ToCityInfo(route.City);
            foreach (Point p in route.Points)
            {
                rez.Points.Add(PointConverter.ToPointInfo(p));
            }
            return rez;
        }
    }
}
