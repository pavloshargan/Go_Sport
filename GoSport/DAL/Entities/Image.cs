using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public byte[] BinaryImage { get; set; }
        public virtual Activity Activity { get; set; }
    }
}
