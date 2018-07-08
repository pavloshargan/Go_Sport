using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCF.DataContracts
{
    [DataContract]
    public class CountryInfo
    {
        //public CountryInfo()
        //{
        //    Cities = new List<string>();
        //}
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public virtual List<CityInfo> Cities { get; set; }


    }
}
