using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace WCF
{
    public static class UserConverter
    {
        public static User ToUser(UserInfo user)
        {
            using (DataModel context = new DataModel())
            {
                return context.Users.FirstOrDefault(x => x.Login == user.Login);
            }
        }
        public static UserInfo ToUserInfo(User user)
        {
            UserInfo rez = new UserInfo();
            rez.Firstname = user.Firstname;
            rez.LastName = user.LastName;
            rez.Login = user.Login;
            rez.Phone = user.Phone;
            rez.Email = user.Email;
            rez.City = CityConverter.ToCityInfo(user.City);
            return rez;
        }
    }

}
