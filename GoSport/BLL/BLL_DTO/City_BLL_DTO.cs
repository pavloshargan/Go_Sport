using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL_DTO
{
    
    public class City_BLL_DTO
    {
        
        public string Name { get; set; }
        
        public Country_BLL_DTO Country { get; set; }

    }
}
