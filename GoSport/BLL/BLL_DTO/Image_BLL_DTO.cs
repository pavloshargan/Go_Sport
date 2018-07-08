using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL_DTO
{ 
    public class Image_BLL_DTO
    {
        
        public byte[] BinaryImage { get; set; }
      
        public Activity_BLL_DTO Activity { get; set; }
    }
}
