using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF
{
    public static class RouteConverter
    {
     /*   public static Route ToRoute(RouteInfo route)
        {
            Route rez = new Route();
            using (DataModel context = new DataModel())
            {
                rez.City = context.Cities.First(x => x.Name == route.City);

                foreach(PointInfo p in route.Points)
                {
                    rez.Points.Add(new Point() { Latitude=p.Latitude,Longitude=p.Longitude});
                }
            }
            return rez;
        }

        public static RouteInfo ToRouteInfo(Route route)
        {
            RouteInfo rez = new RouteInfo();
            rez.City =route.City.Name;
            foreach (Point p in route.Points)
            {
                rez.Points.Add(PointConverter.ToPointInfo(p));
            }
            return rez;
        }*/
    }
}
