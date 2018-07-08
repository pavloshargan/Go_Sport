using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using BLL.BLL_DTO;
using BLL.Converter;
using DAL;
using DAL.Entities;
using AutoMapper;
namespace BLL
{
    public class BLL_Data : IBLL_Data
    {
        private readonly DataModel ctx = new DataModel();

        #region Gets
    
        public List<City_BLL_DTO> GetCities()
        {
            Mapper.Reset();
            Mapper.Initialize(cfg => cfg.CreateMap<City, City_BLL_DTO>());
            var dest = Mapper.Map<List<City>, List<City_BLL_DTO>>(ctx.Cities.ToList());
            return dest;
        }
        public List<Country_BLL_DTO> GetCountries()
        {
            Mapper.Reset();
            Mapper.Initialize(cfg => cfg.CreateMap<Country, Country_BLL_DTO>());
            var dest = Mapper.Map<List<Country>, List<Country_BLL_DTO>>(ctx.Countries.ToList());
            return dest;
        }
        public List<ActivityType_BLL_DTO> GetActivityTypes()
        {
            List<ActivityType_BLL_DTO> rez = new List<ActivityType_BLL_DTO>();
            foreach (ActivityType a in ctx.ActivityTypes)
            {
                rez.Add(new ActivityType_BLL_DTO() { Name=a.Name});
            }
            return rez;
        }

        public List<Activity_BLL_DTO> GetActivities()
        {
            Mapper.Reset();
            Mapper.Initialize(cfg => cfg.CreateMap<Activity, Activity_BLL_DTO>());
            var dest = Mapper.Map<List<Activity>, List<Activity_BLL_DTO>>(ctx.Activities.ToList());
            return dest;
        }
        public List<Activity_BLL_DTO> GetMyActivities(Token_BLL_DTO token)
        {
            return null;
            //Mapper.Reset();
            //Mapper.Initialize(cfg => cfg.CreateMap<Activity, Activity_BLL_DTO>());
            //var dest = Mapper.Map<List<Activity>, List<Activity_BLL_DTO>>(ctx.Activities.Where(x => x.Users.First() == Converter_BLL_DTO.ToToken(token).User).ToList());
            //return dest;
        }
        public Token_BLL_DTO GetTokenByKey(string key)
        {
            Mapper.Reset();
            Mapper.Initialize(cfg => cfg.CreateMap<Token, Token_BLL_DTO>());
            var dest = Mapper.Map<Token, Token_BLL_DTO>(ctx.Tokens.FirstOrDefault(x => x.Key == key));
            return dest;
        }
        #endregion

        #region All_Add
        public void Add_User(string _firstname, string _lastname, string _login, string _email, string _phone, string _pass, string _city, string _country)
        {
            ctx.Users.Add(new User()
            {
                Firstname = _firstname,
                LastName = _lastname,
                Login = _login,
                Email = _email,
                Phone = _phone,
                Password = _pass,
                City = ctx.Cities.FirstOrDefault(x => x.Name == _city && x.Country.Name == _country)
            });
            ctx.SaveChanges();
        }
        public void Add_UnconfirmedUser(string _firstname, string _lastname, string _login, string _email, string _phone, string _pass, string _city, string _country)
        {
            ctx.UnconfirmedUsers.Add(new UnconfirmedUser()
            {
                Firstname = _firstname,
                LastName = _lastname,
                Login = _login,
                Email = _email,
                Phone = _phone,
                City = _city,
                Country = _country,
                Password = _pass
            });
            ctx.SaveChanges();
        }
        public void CreateActivity(Activity_BLL_DTO activity)
        {
            Activity a = Converter_BLL_DTO.ToActivity(activity, ctx);
            ctx.Activities.Add(a);
            ctx.SaveChanges();
        }
        #endregion

        #region Regestration

        public bool SignUp(string _firstname, string _lastname, string _login, string _email, string _phone, string _pass, string _city, string _country)
        {
            if (ctx.Users.Any(x => x.Login == _login))
            {
                return false;
            }
            if (ctx.Users.Any(x => x.Email == _email))
            {
                return false;
            }
            Add_UnconfirmedUser(_firstname, _lastname, _login, _email, _phone, _pass, _city, _country);
            return true;
        }
        public void SendCode(string Email)
        {
            Random random = new Random();
            string code = random.Next(100000, 999999).ToString();


            ctx.UnconfirmedUsers.FirstOrDefault(x => x.Email == Email).Code = code;
            ctx.SaveChanges();
            MailMessage message = new System.Net.Mail.MailMessage(new MailAddress("pasrserwork@gmail.com", "Igor"), new MailAddress((Email)));
            message.Body = code;
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("pasrserwork@gmail.com", "12parser_work");
            smtpClient.EnableSsl = true;
            smtpClient.Send(message);
        }
        public bool ConfirmEmail(string Email, string code)
        {
            UnconfirmedUser unconfirmedUser = ctx.UnconfirmedUsers.FirstOrDefault(x => x.Email == Email && x.Code == code);
            if (code == unconfirmedUser.Code)
            {
                User a = new User()
                {
                    Firstname = unconfirmedUser.Firstname,
                    LastName = unconfirmedUser.LastName,
                    Password = unconfirmedUser.Password,
                    Email = unconfirmedUser.Email,
                    Login = unconfirmedUser.Login,
                    Phone = unconfirmedUser.Phone,
                    City = ctx.Cities.First(x => x.Name == unconfirmedUser.City)
                };
                Add_User(a);

                Random random = new Random();
                string key = random.Next(100000, 999999).ToString();

                ctx.Tokens.Add(new Token() { User = a, Key = key, Date = DateTime.Now });
                ctx.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }


        #endregion

        #region Authentification
        public string SignIn(string Login, string Password)
        {
            if (ctx.Users.Any(x => x.Login == Login && x.Password == Password))
            {
                User CurrentSession = ctx.Users.FirstOrDefault(x => x.Login == Login && x.Password == Password);

                return ctx.Tokens.FirstOrDefault(x => x.User.Login == CurrentSession.Login).Key;
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region Private Methods
        private void Add_User(User user)
        {
            ctx.Users.Add(user);
            ctx.SaveChanges();
        }

       
        #endregion
    }



}
