using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Firstname { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        public virtual City City { get; set; }

        public virtual ICollection<User> Folowers { get; set; }
        public virtual ICollection<User> Folowing { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public User()
        {
            Activities = new List<Activity>();
            Folowers = new List<User>();
            Folowing = new List<User>();
        }
    }
}
