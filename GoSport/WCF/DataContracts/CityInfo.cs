using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCF.DataContracts
{
    [DataContract]
    public class CityInfo
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public CountryInfo Country { get; set; }

    }
}
