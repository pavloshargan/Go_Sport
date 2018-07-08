using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Converter;
using BLL.BLL_DTO;
namespace BLL
{
    public interface IBLL_Data
    {
        List<City_BLL_DTO> GetCities();
        List<Country_BLL_DTO> GetCountries();
        List<string> GetActivityTypes();
        List<Activity_BLL_DTO> GetActivities();
        List<Activity_BLL_DTO> GetMyActivities(Token_BLL_DTO token);
        void Add_User(string _firstname, string _lastname, string _login, string _email, string _phone, string _pass, string _city, string _country);
        void Add_UnconfirmedUser(string _firstname, string _lastname, string _login, string _email, string _phone, string _pass, string _city, string _country);
        bool SignUp(string _firstname, string _lastname, string _login, string _email, string _phone, string _pass, string _city, string _country);
        void SendCode(string Email);
        bool ConfirmEmail(string Email, string code);
        string SignIn(string Login, string Password);
        void CreateActivity(Activity_BLL_DTO activity);
        Token_BLL_DTO GetTokenByKey(string key);


    }
}
