using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL_DTO 
{
    
    public class Country_BLL_DTO
    {
        public Country_BLL_DTO()
        {
            Cities = new List<City_BLL_DTO>();
        }
       
        public string Name { get; set; }
        
        public ICollection<City_BLL_DTO> Cities { get; set; }
    }
}
