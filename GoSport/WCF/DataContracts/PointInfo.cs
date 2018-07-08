﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCF.DataContracts
{
    [DataContract]
    public class PointInfo
    {
        [DataMember]
        public decimal Longitude { get; set; }
        [DataMember]
        public decimal Latitude { get; set; }

    }
}