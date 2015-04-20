using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Repositories.CountryRepository;
using DAL.Repositories.TripRepository;
using DAL.Repositories.UserRepository;

namespace vITs.Logic
{
    class HandleItems
    {
        public List<Country> SendCountryList()
        {
            return CountryRepository.GetAllCountries();
            
        }

        public static List<Trip> SendTripList()
        {
            return TripRepository.GetAllTrips();
        }

        public List<User> SendBossList()
        {
            return UserHandling.getBosses();
        }  
    }
}
