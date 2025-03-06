using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess1;
using DVLD_Models1;

namespace DVLD_Business1
{
    public class clsCountry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private clsCountry(CountryDTO Country)
        {
            this.Id = Country.Id;
            this.Name = Country.Name;
        }
        public static clsCountry Find(int CountryID)
        {
            CountryDTO Country = clsCountryData.GetCountryInfo(CountryID);
            if (Country == null)
                return null;
            return new clsCountry(Country);
        }
        public static clsCountry Find(string CountryName)
        {
            CountryDTO Country = clsCountryData.GetCountryInfo(CountryName);
            if (Country == null)
                return null;
            return new clsCountry(Country);
        }
        public static DataTable GetAllCountries()
        {
            return clsCountryData.GetAllCountries();
        }
        public static bool IsExist(string CountryName)
        {
            return clsCountryData.IsCountryExistByName(CountryName);
        }
    }
}
