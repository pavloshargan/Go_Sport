using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace WCF
{
    public static class CountryConverter
    {
        public static Country ToCountry(CountryInfo info)
        {
            Country rez = new Country();
            foreach (CityInfo a in info.CityInfos)
            {
                rez.Cities.Add(new City() { Name = a.Name });
            }
            rez.Name = info.Name;
            return rez;
        }

        public static CountryInfo ToCountryInfo(Country country)
        {
            CountryInfo rez = new CountryInfo();
            foreach (City c in country.Cities)
            {
                rez.CityInfos.Add(new CityInfo() { Name = c.Name });

            }
            rez.Name = country.Name;


            return rez;
        }
    }
}
