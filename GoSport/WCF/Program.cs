using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WCF
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(Service));
            sh.Open();
            Console.WriteLine("Started...");
            Console.ReadLine();
            sh.Close();
        }
    }
}
