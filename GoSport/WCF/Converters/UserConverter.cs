using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF
{
    public static class UserConverter
    {
        
     /*   public static User ToUser(UserInfo user)
        {
            using (DataModel context = new DataModel())
            {
                return context.Users.FirstOrDefault(x => x.Login == user.Login);
            }
            
        }
        public static UserInfo ToUserInfo(User user)
        {
            UserInfo rez = new UserInfo();
            using (DataModel context = new DataModel())
            {
                
                rez.Firstname = user.Firstname;
                rez.LastName = user.LastName;
                rez.Login = user.Login;
                rez.Phone = user.Phone;
                rez.Email = user.Email;
                City city = context.Cities.FirstOrDefault(x => x.Country.Name == user.City.Country.Name && x.Name == user.City.Name);
                rez.City = CityConverter.ToCityInfo(city);

            }
            return rez;
        }*/
    }

}
