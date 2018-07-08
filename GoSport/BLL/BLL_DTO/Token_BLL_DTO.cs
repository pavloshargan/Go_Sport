using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL_DTO
{
    public class Token_BLL_DTO
    {
      
        public User_BLL_DTO User { get; set; }
      
        public string Key { get; set; }
       
        public DateTime Date { get; set; }
    }
}
