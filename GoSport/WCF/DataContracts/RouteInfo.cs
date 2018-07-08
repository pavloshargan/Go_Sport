using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCF.DataContracts
{
    [DataContract]
    public class RouteInfo
    {
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public ICollection<PointInfo> Points { get; set; }
        public RouteInfo()
        {
            Points = new List<PointInfo>();
        }


    }

}
