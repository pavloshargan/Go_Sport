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
        [FaultContract(typeof(IncorrectInputData))]
        [OperationContract]
        void SignUp(UserInfo user, string Password);
        [FaultContract(typeof(IncorrectInputData))]
        [OperationContract]
        void SendCode(string Email);
        [OperationContract]
        [FaultContract(typeof(IncorrectInputData))]
        string ConfirmEmail(string Email, string code);
        [OperationContract]
        List<CountryInfo> GetListCountries();
        [OperationContract]
        List<CityInfo> GetListCities();
        [OperationContract]
        [FaultContract(typeof(IncorrectInputData))]
        TokenInfo SignIn(string Email, string Password);
        [OperationContract]
        [FaultContract(typeof(IncorrectInputData))]
        void CreateActivity(ActivityInfo activity, TokenInfo token);
        [OperationContract]
        List<ActivityInfo> GetAllActivities();
        [OperationContract]
        List<ActivityInfo> GetMyActivities(TokenInfo token);

        [OperationContract]
        List<string> GetActivityTypes();



    }


    [DataContract]
    public class TokenInfo
    {
        [DataMember]
        public  UserInfo Session { get; set; }
        [DataMember]
        public string Key { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
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
        public CityInfo City { get; set; }
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


    [DataContract]
    public class ImageInfo
    {
        [DataMember]
        public byte[] BinaryImage { get; set; }
        [DataMember]
        public ActivityInfo Activity { get; set; }
    }


    [DataContract]
    public class ActivityInfo
    {
        [DataMember]
        public  RouteInfo Route { get; set; }
        [DataMember]
        public  string Type { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public ICollection <UserInfo> Users { get; set; }
        [DataMember]
        public ICollection<ImageInfo> ActivityImages { get; set; }
        public ActivityInfo()
        {
            Users = new List<UserInfo>();
            ActivityImages = new List<ImageInfo>();
        }
    }


    [DataContract]
    public class RouteInfo
    {
        [DataMember]
        public CityInfo City { get; set; }
        [DataMember]
        public ICollection<PointInfo> Points { get; set; }
        public RouteInfo()
        {
            Points = new List<PointInfo>();
        }
    }

    [DataContract]
    public class PointInfo
    {
        [DataMember]
        public decimal Longitude { get; set; }
        [DataMember]
        public decimal Latitude { get; set; }
        
    }







}
