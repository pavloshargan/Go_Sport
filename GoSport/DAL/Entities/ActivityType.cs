using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ActivityType
    {
        public ActivityType()
        {
            Activities = new List<Activity>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }

    }
}
