using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL_DTO
{
    public class User_BLL_DTO
    {
       
        public string Login { get; set; }
       
        public string Firstname { get; set; }
       
        public string LastName { get; set; }
       
        public string Email { get; set; }
        
        public string Phone { get; set; }
      
        public City_BLL_DTO City { get; set; }
    }
}
