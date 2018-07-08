using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Activity
    {
        public Activity()
        {
            Users = new List<User>();
            Images = new List<Image>();
        }

        public int Id { get; set; }
        public virtual Route Route { get; set; }
        public virtual ActivityType Type { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Image> Images { get; set; }


       
    }
}
