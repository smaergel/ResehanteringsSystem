using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using DAL;
using DAL.Repositories.CountryRepository;
using DAL.Repositories.TripRepository;
using DAL.Repositories.UserRepository;
using vITs.Models;

namespace vITs.Logic
{
    class HandleItems
    {
        public static List<Country> SendCountryList()
        {
            return CountryRepository.GetAllCountries();

        }

        public static List<Trip> SendTripList()
        {
            return TripRepository.GetAllTrips();
        }

        public static List<User> SendBossList()
        {
            return UserHandling.getBosses();
        }

        //fyller en kombobox med listan av chefer, tar emot cbn som ska fyllas
        public static void FillBossList(ComboBox cb)
        {
            var bossList = SendBossList();
            foreach (var boss in bossList)
            {
                cb.Items.Add(boss.userID);
            }
        }

        //Fyller cbs i skapa rapport fliken med länderna som finns i databasen (landnamn + id)
        public static void FillCbsWithCountries(ComboBox cb, ComboBox cb2)
        {
            var countryCollection = SendCountryList();
            foreach (var countryObject in countryCollection)
            {
                cb.Items.Add(countryObject);
                cb2.Items.Add(countryObject);

            }

        }

        //fyller komboboxarna med existerande resor vid införandet av en combobox i parameterfältet.

        public static void FillTripCbWithAllTrips(ComboBox cb)
        {
            var tripCollection = SendTripList();
            foreach (var tripObject in tripCollection)
            {
                cb.Items.Add(tripObject.tripID);
            }
        }

        public static User GetUser(int id)
        {

            return UserHandling.GetUser(id);

        }

        public static List<User> SendUserList()
        {
            return UserHandling.GetUsers();
        }

        ////returnerar den inloggade användarens id.
        public static int GetCurrentUserId()
        {
            var currentUser = new User { userID = 0 };
            if (Application.Current.Properties.Count > 0)
            {
                currentUser = (User)Application.Current.Properties["currentUser"];
            }


            return currentUser.userID;

        }

        //fyller en listbox med resor som väntar på godkännande
        public static void FillListBoxWithAwaitingApproval(ListBox lb)
        {

            foreach (var trip in SendTripList())
            {
                if (trip.approved == 0)
                {
                    var tripToBeAdded = new TripModel()
                    {
                        TripId = trip.tripID,
                        BossId = trip.boss,
                        Start = trip.start,
                        End = trip.end,
                        Origin = trip.origin,
                        Destination = trip.destination,
                        Prepayment = trip.prepayment,
                        Note = trip.note,
                        Status = trip.approved,
                        User = trip.user
                    };
                    lb.DisplayMemberPath = "TripId";
                    lb.Items.Add(tripToBeAdded);
                }

            }

        }

        public static IEnumerable<Object> GetTrips()
        {
            var trips = TripRepository.getTripsForReports();
            return trips;
        }

        public static IEnumerable<Object> GetTripsFiltered(int month)
        {
            var orderby = TripRepository.filterTrips(month);
            return orderby;
        }



        public static void FillUserList(ComboBox cb)
        {

            var userList = SendUserList();
            foreach (var user in userList)
            {
                if (HandleItems.GetCurrentUserId() != user.userID)
                    cb.Items.Add(user.userID + ". " + user.firstname + " " + user.lastname);
            }
        }

        public static void SendRapport(int inCons, int inDest, DateTime inStart)
        {
            var xmlList = Serializer.Load();
            for (int i = 0; i < xmlList.Count; i++)
            {
                if (xmlList[i].myTrip.User == inCons && xmlList[i].myTrip.Destination == inDest && xmlList[i].myTrip.Start == inStart)
                {
                    FullTrip full = xmlList[i];
                    Trip trip = ModelTransformer.TripModel2Trip(full.myTrip);
                    TripRepository.AddTrip(trip);

                    foreach (var vac in full.myVacation)
                    {
                        vac.tripID = trip.tripID;
                        VacationsRepository.AddVacation(ModelTransformer.VacationModel2Vacation(vac));
                    }
                    foreach (var item in full.myVerifications)
                    {
                        item.tripID = trip.tripID;
                        VerificationRepository.AddVerification(ModelTransformer.VerificationModel2Verification(item));
                    }

                    xmlList.RemoveAt(i);
                }
            }
            Serializer.Overwrite(xmlList);
        }
    }

}

