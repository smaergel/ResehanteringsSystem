using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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

        public static List<Trip> GetAllTrips()
        {
            using (var dbConnect = new DatabaseEntities())
            {
                var trips = dbConnect.Trips.ToList();

                return trips;
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
                Trip trip = dbConnect.Trips.Find(id);

                return trip;
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

        public static void ApproveDenyTrip(int id, int status)
        {

            using (var context = new DatabaseEntities())
            {

               var trip = context.Trips.FirstOrDefault(x => x.tripID == id);

                    if(trip != null)
                    {

                    trip.approved = status;
                    context.SaveChanges();

                    }
                    else
                    {
                        MessageBox.Show("Hittade inte rapporten!");
                    }

            }

        }


        public static IEnumerable<dynamic> getTripsForReports()
        {
            using (var context = new DatabaseEntities())
            {
                //                SELECT trips.tripID, Countries.country1, trips.start, trips.[end], Users.firstname +
                //' ' + Users.lastname as [Consultat], Trips.approved FROM trips
                //JOIN Users ON trips.[user] = Users.userID
                //JOIN Countries ON Trips.destination = Countries.countryID
                var trips = from t in context.Trips
                            join c in context.Countries on t.destination equals c.countryID
                            join u in context.Users on t.user equals u.userID
                            select new
                            {
                                id = t.tripID,
                                destination = c.country1,
                                consultant = u.firstname + " " + u.lastname,
                                date = t.start,
                                status = t.approved
                            };
                IEnumerable<dynamic> tripsList = trips.ToList();
                return tripsList;

                //var list = asd.SelectMany(item => item.id);
            }
        }

        public static IEnumerable<dynamic> filterTrips(int month)
        {

            using (var context = new DatabaseEntities())
            {
                var date = DateTime.Now.AddMonths(month);
                // AllTrips.Where(x => DateTime.Compare(x.date = DateTime.Today.AddMonths(-1)));)
                var trips = from t in context.Trips
                            join c in context.Countries on t.destination equals c.countryID
                            join u in context.Users on t.user equals u.userID
                            where t.start > date
                            orderby t.start descending
                            select new
                            {
                                id = t.tripID,
                                destination = c.country1,
                                consultant = u.firstname + " " + u.lastname,
                                date = t.start,
                                status = t.approved
                            };
                IEnumerable<dynamic> tripsList = trips.ToList();
                return tripsList;
            }
        }

    }
}