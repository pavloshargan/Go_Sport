using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DAL;
namespace WCF
{


    public class Service : IService
    {
        private DataModel context = new DataModel();


        private int CurrentSessionId;
        public void SignUp(UserInfo user, string Password)
        {
            if (context.Users.Any(x => x.Login == user.Login))
            {
                IncorrectInputData fault = new IncorrectInputData();
                fault.Message = "Enter another login";
                fault.Description = "Login has been alredy used";
                throw new FaultException<IncorrectInputData>(fault);
            }
            if (context.Users.Any(x => x.Email == user.Email))
            {
                IncorrectInputData fault = new IncorrectInputData();
                fault.Message = "Enter another Email";
                fault.Description = "Email has been alredy used";
                throw new FaultException<IncorrectInputData>(fault);
            }
            try
            {
                context.UnconfirmedUsers.Add(UnconfirmedUserConverter.ToUnconfirmedUser(user, Password));
                context.SaveChanges();

            }
            catch (Exception ex)
            {
                IncorrectInputData f = new IncorrectInputData();
                f.Message = ex.Message;
                f.Description = ex.Message;
                throw new FaultException<IncorrectInputData>(f);
            }
        }
        public void SendCode(string Email)
        {

            Random random = new Random();
            string code = random.Next(100000, 999999).ToString();


            context.UnconfirmedUsers.FirstOrDefault(x => x.Email == Email).Code = code;
            context.SaveChanges();
            MailMessage message = new MailMessage(new MailAddress("pasrserwork@gmail.com", "Igor"), new MailAddress((Email)));
            message.Body = code;
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("pasrserwork@gmail.com", "12parser_work");
            smtpClient.EnableSsl = true;
            smtpClient.Send(message);
        }
        public string ConfirmEmail(string Email, string code)
        {
            UnconfirmedUser unconfirmedUser = context.UnconfirmedUsers.FirstOrDefault(x => x.Email == Email);
            if (code == unconfirmedUser.Code)
            {
                context.Users.Add(UnconfirmedUserConverter.ToUser(unconfirmedUser));
                Random random = new Random();
                string key = random.Next(100000, 999999).ToString();
                context.Tokens.Add(new Token() { Session = UnconfirmedUserConverter.ToUser(unconfirmedUser), Key = key, Date = DateTime.Now });
                context.SaveChanges();
                return key;
            }
            else
            {
                IncorrectInputData fault = new IncorrectInputData();
                fault.Message = "Wrong code!";
                fault.Description = "The code you have entered is invalid.";
                throw new FaultException<IncorrectInputData>(fault);
            }
        }

        public List<CountryInfo> GetListCountries()
        {
            List<CountryInfo> countries = new List<CountryInfo>();
            foreach (Country a in context.Countries)
            {
                countries.Add(new CountryInfo() { Name = a.Name, CityInfos = CountryConverter.ToCountryInfo(a).CityInfos });
            }
            return countries;
        }
        public List<CityInfo> GetListCities()
        {
            List<CityInfo> cities = new List<CityInfo>();
            foreach (City a in context.Cities)
            {
                cities.Add(new CityInfo() { Name = a.Name, CountryInfo = CountryConverter.ToCountryInfo(a.Country) });
            }
            return cities;
        }
        public string SignIn(string Email, string Password)
        {
            if (context.Users.Any(x => x.Email == Email && x.Password == Password))
            {
                User CurrentSession = context.Users.FirstOrDefault(x => x.Email == Email && x.Password == Password);
                Random random = new Random();
                string key = random.Next(100000, 999999).ToString();

                context.Tokens.FirstOrDefault(x => x.Session == CurrentSession).Key = key;
                context.Tokens.FirstOrDefault(x => x.Session == CurrentSession).Date = DateTime.Now;
                context.SaveChanges();
                return key;
            }
            else
            {
                IncorrectInputData fault = new IncorrectInputData();
                fault.Message = "Incorrect login or password!";
                fault.Description = "Enter another login or password";
                throw new FaultException<IncorrectInputData>(fault);
            }
        }
        public void CreateActivity(ActivityInfo activity, TokenInfo token)
        {
            if (activity.Date < DateTime.Now)
            {
                IncorrectInputData fault = new IncorrectInputData();
                fault.Message = "Incorrect Date";
                fault.Description = "Look on the today's day!";
                throw new FaultException<IncorrectInputData>(fault);
            }
            Activity new_activity = new Activity();
            foreach (ImageInfo im in activity.ActivityImages)
            {
                new_activity.ActivityImages.Add(ImageConverter.ToImage(im));
            }
            new_activity.Date = activity.Date;
            new_activity.Route = RouteConverter.ToRoute(activity.Route);
            new_activity.Type = ActivityTypeConverter.ToActivityType(activity.Type);
            new_activity.Users.Add(UserConverter.ToUser(token.Session));
            context.Activities.Add(new_activity);
            context.SaveChanges();
        }
        public List<ActivityInfo> GetAllActivities()
        {
            List<ActivityInfo> rez = new List<ActivityInfo>();
            foreach(Activity act in context.Activities)
            {
                rez.Add(ActivityConverter.ToActivityInfo(act));
            }
            return rez;
        }
        public List<ActivityInfo> GetMyActivities(TokenInfo token)
        {
            List<ActivityInfo> rez = new List<ActivityInfo>();
            foreach (Activity act in context.Activities.Where(x=>x.Users.First()==TokenConverter.ToToken(token).Session))
            {
                rez.Add(ActivityConverter.ToActivityInfo(act));
            }
            return rez;
        }
      //  public List<>
    }
}
