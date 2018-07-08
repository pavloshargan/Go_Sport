using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using BLL.BLL_DTO;
using WCF.DataContracts;
using AutoMapper;
namespace WCF
{
    public static class CityConverter
    {
        public static List<CityInfo> ToCity(List<City_BLL_DTO> cities)
        {
           
           
           List<CityInfo> dest = new List<CityInfo>();


           foreach(City_BLL_DTO c in cities)
           {
               dest.Add(new CityInfo() { Name=c.Name,Country=CountryConverter.ToCountryInfo(c.Country) });
           }
           return dest;
        }
       /* public static CityInfo ToCityInfo(City city)
        {
            return new CityInfo() { Name = city.Name, CountryInfo = CountryConverter.ToCountryInfo(city.Country)};
        }*/
    }
}
