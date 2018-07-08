using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Route
    {
        public Route()
        {
            Points = new List<Point>();
            Activities = new List<Activity>();
        }

        public int Id { get; set; }
        public virtual City City { get; set; }
        public virtual ICollection<Point> Points { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
    }
}
