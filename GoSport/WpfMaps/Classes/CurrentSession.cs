using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using BLL.BLL_DTO;
namespace WpfMaps
{
    public static class CurrentSession
    {
        public static Token_BLL_DTO TokenInfo { get; set; }
    }
}
