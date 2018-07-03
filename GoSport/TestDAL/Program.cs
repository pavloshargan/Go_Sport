using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace TestDAL
{
    class Program
    {
        static void Main(string[] args)
        {
            DataModel model = new DataModel();
            // model.ConfirmEmails.Add(new ConfirmEmail { Code = "123", Email = "asd" });
            // model.SaveChanges();
            //foreach (ConfirmEmail a in model.ConfirmEmails)
            //{
            //    Console.WriteLine(a.Email+"  "+a.Code);
            //}


            foreach (User a in model.Users)
            {
                Console.WriteLine(a.Firstname);
            }




        }
    }
}
