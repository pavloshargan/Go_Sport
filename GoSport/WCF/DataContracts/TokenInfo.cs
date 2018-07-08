using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCF.DataContracts
{
    [DataContract]
    public class TokenInfo
    {
        [DataMember]
        public UserInfo User { get; set; }
        [DataMember]
        public string Key { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
    }
}
