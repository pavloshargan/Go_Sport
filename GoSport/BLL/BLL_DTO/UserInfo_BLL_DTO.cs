using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL_DTO
{
    public class UserInfo_BLL_DTO
    {
        public string FullName { get; set; }
        public ICollection<User_BLL_DTO> Followers { get; set; }
        
    }

}
