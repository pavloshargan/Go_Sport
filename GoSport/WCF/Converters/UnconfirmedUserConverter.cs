using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF
{
   public static class UnconfirmedUserConverter
    {
     /*  public static UnconfirmedUser ToUnconfirmedUser(UserInfo user, string Password)
        {
            UnconfirmedUser rez = new UnconfirmedUser();
            rez.Firstname = user.Firstname;
            rez.LastName = user.LastName;
            rez.Login = user.Login;
            rez.Password = Password;
            rez.Phone = user.Phone;
            rez.Email = user.Email;
            rez.City = user.City.Name;

            return rez;
        }
       public static User ToUser(UnconfirmedUser user)
        {
            User rez = new User
            {
                Firstname = user.Firstname,
                LastName = user.LastName,
                Login = user.Login,
                Phone = user.Phone,
                Email = user.Email,
                Password = user.Password
            };
            using (DataModel ctx = new DataModel())
            {
                rez.City=ctx.Cities.First(x=>x.Name==user.City);
            }
                
            return rez;
        }*/

       
    }
}
