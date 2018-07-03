using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace WCF.Converters
{
   public static class PointConverter
    {
        public static Point ToPoint(PointInfo point)
        {
            return new Point() { Longitude = point.Longitude, Latitude = point.Latitude };
        }
        public static PointInfo ToPointInfo(Point point)
        {
            return new PointInfo() { Longitude = point.Longitude, Latitude = point.Latitude };
        }
    }
}
