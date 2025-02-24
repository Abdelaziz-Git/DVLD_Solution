using DVLD_Models;
using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DVLD_Business
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
            CountryDTO Country = clsCountryData.GetCountryInfoByID(CountryID);
            if (Country == null)
                return null;
            return new clsCountry(Country);
        }
        public static clsCountry Find(string CountryName)
        {
            CountryDTO Country = clsCountryData.GetCountryInfoByName(CountryName);
            if (Country == null)
                return null;
            return new clsCountry(Country);
        }
        public static DataTable GetAllCountries()
        {
            return clsCountryData.GetAllCountries();
        }   
    }
}
