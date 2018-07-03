using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        [FaultContract(typeof(IncorrectInputData))]
        void SignUp(UserInfo user, string Password);
        [OperationContract]
        void SendCode(string Email);
        [OperationContract]
        [FaultContract(typeof(IncorrectInputData))]
        void ConfirmEmail(string Email, string code);


        [OperationContract]
        List<CountryInfo> GetListCountries();

        [OperationContract]
        List<CityInfo> GetListCities();
    }

    [DataContract]
    public class IncorrectInputData
    {
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public string Description { get; set; }
    }

    [DataContract]
    public class UserInfo
    {
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Firstname { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string City { get; set; }
    }



    [DataContract]
    public class CountryInfo
    {
        public CountryInfo()
        {
            CityInfos = new List<CityInfo>();
        }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public ICollection<CityInfo> CityInfos { get; set; } 
    }

    [DataContract]
    public class CityInfo
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public CountryInfo CountryInfo { get; set; }

    }




}
