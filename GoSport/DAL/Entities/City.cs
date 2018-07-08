using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class City
    {
        public City()
        {
            Users = new List<User>();
            Routes = new List<Route>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Route> Routes { get; set; }


    }
}
