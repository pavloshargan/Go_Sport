using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCF.DataContracts
{
    [DataContract]
    public class ImageInfo
    {
        [DataMember]
        public byte[] BinaryImage { get; set; }
        [DataMember]
        public ActivityInfo Activity { get; set; }
    }
}
