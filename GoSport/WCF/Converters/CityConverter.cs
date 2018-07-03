using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace WCF.Converters
{
    public static class CityConverter
    {
        public static City ToCity(CityInfo city)
        {
            using (DataModel context = new DataModel())
            {
                return context.Cities.FirstOrDefault(x=>x.Name==city.Name&& x.Country.Name==city.CountryInfo.Name);
            }
        }
        public static CityInfo ToCityInfo(City city)
        {
            return new CityInfo() { Name = city.Name, CountryInfo = CountryConverter.ToCountryInfo(city.Country)};
        }
    }
}
