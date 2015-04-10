using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.TripRepository
{
    /// <summary>
    /// Contains methods for managing the Trips table
    /// 
    /// Author: Yvell/Waerner
    /// </summary>
    public class TripRepository
    {
        /// <summary>
        /// Add a new trip
        /// </summary>
        /// <param name="trip">Object: Trip</param>
        public static void AddTrip(Trip trip)
        {
            using (var dbConnect = new DatabaseEntities())
            {
                dbConnect.Trips.Add(trip);
                dbConnect.SaveChanges();
            }
        }

        /// <summary>
        /// Remove a specific trip
        /// </summary>
        /// <param name="id">TripID</param>
        public static void RemoveTrip(int id)
        {
            using (var dbConnect = new DatabaseEntities())
            {
                var tripToDelete = new Trip {tripID = id};
                dbConnect.Trips.Attach(tripToDelete);
                dbConnect.Trips.Remove(tripToDelete);
                dbConnect.SaveChanges();
            }
        }

        /// <summary>
        /// Retreive a specific trip from the Trips table
        /// </summary>
        /// <param name="id">TripID</param>
        public static Trip GetTrip(int id)
        {
            using (var dbConnect = new DatabaseEntities())
            {
                var thisTrip = new Trip {tripID = id};
                dbConnect.Trips.Attach(thisTrip);

                return thisTrip;
            }
        }

        /// <summary>
        /// Edit a stored trip
        /// </summary>
        /// <param name="trip">Object: Trip</param>
        public static void UpdateTrip(Trip trip)
        {
            using (var dbConnect = new DatabaseEntities())
            {
                var storedTrip = (from s in dbConnect.Trips
                    where s.tripID == trip.tripID
                    select s).FirstOrDefault();

                if (storedTrip == null) return;

                storedTrip.origin = trip.origin;
                storedTrip.destination = trip.destination;
                storedTrip.start = trip.start;
                storedTrip.end = trip.end;
                storedTrip.prepayment = trip.prepayment;
                storedTrip.note = trip.note;
                storedTrip.user = trip.user;

                dbConnect.SaveChanges();
            }
        }
    }
}