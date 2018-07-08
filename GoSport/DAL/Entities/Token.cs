using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Token
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public string Key { get; set; }
        public DateTime Date { get; set; }
    }
}
