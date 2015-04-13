using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.CountryRepository
{
    public class CountryRepository
    {
        /// <summary>
        /// Add a new country to the Countries table
        /// </summary>
        /// <param name="country">Name of the country</param>
        /// <param name="allowance">Allowance provided by SKV</param>
        public static void AddCountry(string country, int allowance)
        {
            using (var dbConnect = new DatabaseEntities())
            {
                var newCountry = new Country
                {
                    country1 = country,
                    allowance = allowance
                };

                dbConnect.Countries.Add(newCountry);
                dbConnect.SaveChanges();
            }
            
        }

        /// <summary>
        /// Remove a ccountry using CountryID
        /// </summary>
        /// <param name="id">CountryID</param>
        public static void DeleteCountry(int id)
        {
            using (var dbConnect = new DatabaseEntities())
            {
                var countryToDelete = new Country { countryID = id };
                dbConnect.Countries.Attach(countryToDelete);
                dbConnect.Countries.Remove(countryToDelete);
                dbConnect.SaveChanges();
            }
        }

        /// <summary>
        /// Returns all rows from the Countries table
        /// </summary>
        /// <returns>List of all (Object:) Countries</returns>
        public static List<Country> GetAllCountries()
        {
            using (var dbConnect = new DatabaseEntities())
            {
                var countries = dbConnect.Countries.ToList();

                return countries;

            }

        }
    }
}
