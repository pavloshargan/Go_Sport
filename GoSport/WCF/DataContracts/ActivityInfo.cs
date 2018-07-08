using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCF.DataContracts
{
    [DataContract]
    public class ActivityInfo
    {
        [DataMember]
        public RouteInfo Route { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public List<UserInfo> Users { get; set; }
        [DataMember]
        public ICollection<ImageInfo> Images { get; set; }
        public ActivityInfo()
        {
            Users = new List<UserInfo>();
            Images = new List<ImageInfo>();
        }

    }
}
