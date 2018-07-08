using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.BLL_DTO;
using WCF.DataContracts;
using AutoMapper;

namespace WCF
{
    public static class CountryConverter
    {
        public static List<CountryInfo> ToCountryInfo(List<Country_BLL_DTO> info)
        {
            List<CountryInfo> rez = new List<CountryInfo>();
        
            foreach (Country_BLL_DTO a in info)
            {
                rez.Add(new CountryInfo() { Name = a.Name, Cities = CityConverter.ToCity(a.Cities.ToList()) });
            }
            return rez;
        }

        public static CountryInfo ToCountryInfo(Country_BLL_DTO country)
        {
            return new CountryInfo() { Name = country.Name, Cities = CityConverter.ToCity(country.Cities.ToList()) };
        }
    }
}
