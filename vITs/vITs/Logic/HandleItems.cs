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
                cb.Items.Add(countryObject.countryID + ". " + countryObject.country1);
                cb2.Items.Add(countryObject.countryID + ". " + countryObject.country1);

            }

        }

        //fyller komboboxarna med existerande resor vid införandet av en combobox i parameterfältet.

        public static void FillTripCbWithAllTrips(ComboBox cb)
        {
            var tripCollection = SendTripList();
            foreach (var tripObject in tripCollection)
            {
                cb.Items.Add(tripObject.note);
            }
        }

        public static User GetUser(int id)
        {

            return UserHandling.GetUser(id);

        }

        public List<User> SendUserList()
        {
            return UserHandling.GetUsers();
        }

        ////returnerar den inloggade användarens id.
        public static int GetCurrentUserId()
        {
            
            var currentUser = (User) Application.Current.Properties["currentUser"];


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

        }  
    }

