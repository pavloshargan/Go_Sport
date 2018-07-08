using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL_DTO
{
    
    public class Route_BLL_DTO
    {
      
        public City_BLL_DTO City { get; set; }
       
        public ICollection<Point_BLL_DTO> Points { get; set; }
        public Route_BLL_DTO()
        {
            Points = new List<Point_BLL_DTO>();
        }


    }

}
