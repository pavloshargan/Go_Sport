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
                context.UnconfirmedUsers.Add(UserConverter.ToUnconfirmedUser(user, Password));
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
        public void ConfirmEmail(string Email, string code)
        {
            UnconfirmedUser unconfirmedUser = context.UnconfirmedUsers.FirstOrDefault(x => x.Email == Email);
            if (code == unconfirmedUser.Code)
            {
                context.Users.Add(UserConverter.ToUser(unconfirmedUser));
                context.SaveChanges();
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
            foreach(City a in context.Cities)
            {
                cities.Add(new CityInfo() { Name = a.Name, CountryInfo = CountryConverter.ToCountryInfo(a.Country)});
            }
            return cities;
        }
    }
}
