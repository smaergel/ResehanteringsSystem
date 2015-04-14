using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Repositories.CountryRepository;
using DAL.Repositories.TripRepository;

namespace vITs.Logic
{
    class HandleItems
    {
        public List<Country> SendCountryList()
        {
            return CountryRepository.GetAllCountries();
            
        }

        public List<Trip> SendTripList()
        {
            return TripRepository.GetAllTrips();
        }

    }
}
