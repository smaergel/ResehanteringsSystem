using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using vITs.Models;
using DAL.Repositories.TripRepository;

namespace vITs.Logic
{
    class AddItems
    {
        public static void AddTrip(TripModel trip)
        {
            //överför modellen TripModell till ett objekt av databastypen Trip
            var newTrip = new Trip();
            newTrip.origin = trip.origin;
            newTrip.destination = trip.destination;
            newTrip.start = trip.start;
            newTrip.end = trip.end;
            newTrip.prepayment = trip.prepayment;
            newTrip.note = trip.note;
            newTrip.user = trip.user;
            newTrip.boss = trip.boss;
            newTrip.approved = trip.status;

            //för in datan i databasen
            TripRepository.AddTrip(newTrip);

        }

        public static void ApproveDenyReport(int id, bool status)
        {
            
            TripRepository.ApproveDenyTrip(id, status);

        }

    }
}
