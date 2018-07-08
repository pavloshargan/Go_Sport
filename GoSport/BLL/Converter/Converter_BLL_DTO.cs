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
        public static  DataModel data = new DataModel();
        public static User ToUser(User_BLL_DTO _bll_user)
        {
            Mapper.Reset();
            Mapper.Initialize(cfg => cfg.CreateMap<User_BLL_DTO, User>());
            var dest = Mapper.Map<User_BLL_DTO, User>(_bll_user);
            return dest;
        }
        public static ActivityType ToActivityType(ActivityType_BLL_DTO _bll_activity_type)
        {
            Mapper.Reset();
            Mapper.Initialize(cfg => cfg.CreateMap<ActivityType_BLL_DTO, ActivityType>());
            var dest = Mapper.Map<ActivityType_BLL_DTO, ActivityType>(_bll_activity_type);
            return dest;
        }
        public static Activity ToActivity(Activity_BLL_DTO activity_BLL_DTO)
        {
            Activity activity = new Activity();
            activity.Type = Converter_BLL_DTO.ToActivityType(activity_BLL_DTO.Type);
            activity.Route = ToRoute(activity_BLL_DTO.Route);
          
            activity.Users=ToUserList( activity_BLL_DTO.Users.ToList());
            activity.Date = activity_BLL_DTO.Date;

            return activity;
        }
        public static City ToCity(City_BLL_DTO city_BLL_DTO)
        {
            
            City city = data.Cities.FirstOrDefault(x => x.Name == city_BLL_DTO.Name);
            return city;
        }
        public static Country ToCountry(Country_BLL_DTO Country_BLL_DTO)
        {
            /* Mapper.Reset();
             Mapper.Initialize(cfg => cfg.CreateMap<Country_BLL_DTO, Country>());
             var dest = Mapper.Map<Country_BLL_DTO, Country>(Country_BLL_DTO);
             return dest;*/
            
            return data.Countries.FirstOrDefault(x => x.Name == Country_BLL_DTO.Name);
        }
        public static Image ToImage(Image_BLL_DTO Image_BLL_DTO)
        {
            Mapper.Reset();
            Mapper.Initialize(cfg => cfg.CreateMap<Image_BLL_DTO, Image>());
            var dest = Mapper.Map<Image_BLL_DTO, Image>(Image_BLL_DTO);
            return dest;

        }
        public static Point ToPoint(Point_BLL_DTO Point_BLL_DTO)
        {
            Mapper.Reset();
            Mapper.Initialize(cfg => cfg.CreateMap<Point_BLL_DTO, Point>());
            var dest = Mapper.Map<Point_BLL_DTO, Point>(Point_BLL_DTO);
            return dest;

        }
        public static Route ToRoute(Route_BLL_DTO Route_BLL_DTO)
        {
            /*Mapper.Reset();
            Mapper.Initialize(cfg => cfg.CreateMap<Route_BLL_DTO, Route>());
            var dest = Mapper.Map<Route_BLL_DTO, Route>(Route_BLL_DTO);
            return dest;
            */
            Route route = new Route();
            route.City = ToCity(Route_BLL_DTO.City);
            foreach(Point_BLL_DTO p in Route_BLL_DTO.Points)
            {
                route.Points.Add(ToPoint(p));
            }
            return route;
        }
        public static Token ToToken(Token_BLL_DTO Token_BLL_DTO)
        {
            Mapper.Reset();
            Mapper.Initialize(cfg => cfg.CreateMap<Token_BLL_DTO, Token>());
            var dest = Mapper.Map<Token_BLL_DTO, Token>(Token_BLL_DTO);
            return dest;

        }
        public static List<Token> ToTokenList(List<Token_BLL_DTO> tokens)
        {
            Mapper.Reset();
            Mapper.Initialize(cfg => cfg.CreateMap<Token_BLL_DTO, Token>());
            var dest = Mapper.Map<List<Token_BLL_DTO>, List<Token>>(tokens);
            return dest;
        }
        public static List<User> ToUserList(List<User_BLL_DTO> users)
        {
            Mapper.Reset();
            Mapper.Initialize(cfg => cfg.CreateMap<User_BLL_DTO, User>());
            var dest = Mapper.Map<List<User_BLL_DTO>, List<User>>(users);
            return dest;
        }
    }
}
