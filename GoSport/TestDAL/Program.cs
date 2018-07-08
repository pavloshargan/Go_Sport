using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using BLL.BLL_DTO;
using TestDAL.ServiceReference1;
using DAL;
using DAL.Entities;
namespace TestDAL
{
    class Program
    {
        static void Main(string[] args)
        {
            // DataModel model = new DataModel();
            // model.ConfirmEmails.Add(new ConfirmEmail { Code = "123", Email = "asd" });
            // model.SaveChanges();
            //foreach (ConfirmEmail a in model.ConfirmEmails)
            //{
            //    Console.WriteLine(a.Email+"  "+a.Code);
            //}


            //foreach (User a in model.Users)
            //{
            //    Console.WriteLine(a.Firstname);
            //}

            // foreach (City a in model.Cities)
            // {
            // Console.WriteLine(model.Cities.FirstOrDefault(x=>x.Name=="Rivne").Name);
            // }

            //BLL_Data _bll = new BLL_Data();
            ////Console.WriteLine(_bll.SignIn("misha", "qwe"));
            //_bll.SignUp("Igor","Klikun","klikuni","klikun2001@gmail.com","132","1","Rivne","Ukraine");
            //_bll.SendCode("klikun2001@gmail.com");
            //bool a=_bll.ConfirmEmail("klikun2001@gmail.com", Console.ReadLine());
            //Console.WriteLine(a);

            ServiceClient service = new ServiceClient();
            // Console.WriteLine(service.SignIn("misha", "qwe"));
            // TokenInfo a = service.GetTokenByKey(Console.ReadLine());
            // Console.WriteLine(a.User.Firstname);*/

            foreach (CountryInfo a in service.GetListCountries())
            {
                Console.WriteLine(a.Name);
                foreach (CityInfo item in a.Cities)
                {
                    Console.WriteLine(" " + item.Name);
                }
            }
            /* foreach (ActivityInfo a in service.GetAllActivities())
             {
                 Console.WriteLine(a.Type);
             }*/


            /*BLL_Data _bll = new BLL_Data();
            foreach (Country_BLL_DTO a in _bll.GetCountries())
            {
                Console.WriteLine(a.Name);
                foreach (City_BLL_DTO item in a.Cities)
                {
                    Console.WriteLine(" " + item.Name);
                }
            }*/


            //Console.WriteLine(_bll.SignIn("misha", "qwe"));
            /* DataModel data = new DataModel();
             foreach(Country a in data.Countries)
             {
                 Console.WriteLine(a.Name);
             }*/

        }
    }
}
