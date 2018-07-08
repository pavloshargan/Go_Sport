using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL_DTO
{
    public class Activity_BLL_DTO
    {
        public Route_BLL_DTO Route { get; set; }
        
        public ActivityType_BLL_DTO Type { get; set; }
       
        public DateTime Date { get; set; }
       
        public ICollection<User_BLL_DTO> Users { get; set; }
       
        public ICollection<Image_BLL_DTO> Images { get; set; }
        public Activity_BLL_DTO()
        {
            Users = new List<User_BLL_DTO>();
            Images = new List<Image_BLL_DTO>();
        }

    }
}
