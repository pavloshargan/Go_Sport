using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Entities;
using BLL.BLL_DTO;
using AutoMapper;
namespace BLL.Converter
{
    public class Converter_BLL_DTO
    {

        public static User ToUser(User_BLL_DTO _bll_user, DataModel context)
        {
            return context.Users.FirstOrDefault(x => x.Login == _bll_user.Login);
        }
        public static ActivityType ToActivityType(ActivityType_BLL_DTO _bll_activity_type, DataModel context)
        {
            return context.ActivityTypes.FirstOrDefault(x => x.Name == _bll_activity_type.Name);
        }
        public static Activity ToActivity(Activity_BLL_DTO activity_BLL_DTO, DataModel context)
        {
            Activity activity = new Activity();
            activity.Type = Converter_BLL_DTO.ToActivityType(activity_BLL_DTO.Type, context);
            activity.Route = ToRoute(activity_BLL_DTO.Route, context);
          
            foreach(User_BLL_DTO us in activity_BLL_DTO.Users)
            {
                activity.Users.Add(context.Users.FirstOrDefault(x => x.Login == us.Login));
            }
            activity.Date = activity_BLL_DTO.Date;

            return activity;
        }
        public static City ToCity(City_BLL_DTO city_BLL_DTO, DataModel context)
        {
            
            City city = context.Cities.FirstOrDefault(x => x.Name == city_BLL_DTO.Name);
            return city;
        }
        public static Country ToCountry(Country_BLL_DTO Country_BLL_DTO, DataModel context)
        {
            return context.Countries.FirstOrDefault(x => x.Name == Country_BLL_DTO.Name);
        }
        public static Image ToImage(Image_BLL_DTO Image_BLL_DTO, DataModel context)
        {
            return new Image() { BinaryImage = Image_BLL_DTO.BinaryImage };//пофіксить в базі
        }
        public static Point ToPoint(Point_BLL_DTO Point_BLL_DTO, DataModel context)
        {
            return new Point() { Longitude = Point_BLL_DTO.Longitude, Latitude = Point_BLL_DTO.Latitude };
        }
        public static Route ToRoute(Route_BLL_DTO Route_BLL_DTO, DataModel context)
        {
            Route route = new Route();
            route.City = ToCity(Route_BLL_DTO.City, context);
            foreach(Point_BLL_DTO p in Route_BLL_DTO.Points)
            {
                route.Points.Add(ToPoint(p,context));
            }
            return route;
        }
        public static Token ToToken(Token_BLL_DTO Token_BLL_DTO, DataModel context)
        {
            return context.Tokens.FirstOrDefault(x => x.User.Login==Token_BLL_DTO.User.Login);

        }
        public static List<Token> ToTokenList(List<Token_BLL_DTO> tokens, DataModel context)
        {
            List<Token> rez = new List<Token>();
            foreach(Token_BLL_DTO t in tokens)
            {
                rez.Add(ToToken(t, context));
            }
            return rez;
        }
        public static List<User> ToUserList(List<User_BLL_DTO> users, DataModel context)
        {
            List<User> rez = new List<User>();
            foreach (User_BLL_DTO us in users)
            {
                rez.Add(ToUser(us, context));
            }
            return rez;
        }
    }
}
