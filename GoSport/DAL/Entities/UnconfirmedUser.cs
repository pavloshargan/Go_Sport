using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class UnconfirmedUser
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Firstname { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        public string City { get; set; }
        public string Country { get; set; }
        public string Code { get; set; }

    }
}
