using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DAL;
using vITs.Logic;
using vITs.Models;

namespace vITs
{
    /// <summary>
    /// Interaction logic for RapportHantering.xaml
    /// </summary>
    public partial class RapportHantering : Window
    {
        public RapportHantering()
        {
            InitializeComponent();
            fillCbsWithCountries();
            filTripCbWithAllTrips();
        }

        //Fyller cbs i skapa rapport fliken med länderna som finns i databasen (landnamn + id)
        private void fillCbsWithCountries()
        {
            var hh = new HandleItems();
            var CountryCollection = hh.SendCountryList();
            foreach (var countryObject in CountryCollection)
            {
                cbCountryArrival.Items.Add(countryObject.countryID + ". " + countryObject.country1);
                cbCountryDeparture.Items.Add(countryObject.countryID + ". " + countryObject.country1);
    
            }
            
        }

        private void filTripCbWithAllTrips()
        {
            var hh = new HandleItems();
            var TripCollection = hh.SendTripList();
            foreach (var TripObject in TripCollection)
            {
                cbPickTripExpensesTab.Items.Add(TripObject.note);
            }
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            //skapar en modell av typen resa
            var trip = new TripModel();
            //fyller modellen med information
            trip.Origin = cbCountryDeparture.SelectedIndex + 1;
            trip.Destination = cbCountryArrival.SelectedIndex + 1;
            trip.Start = (DateTime) dpStartDate.SelectedDate;
            trip.End = (DateTime) dpEndDate.SelectedDate;
            var prepay = tbPrepaySum.Text;
            int prepaySum;
            int.TryParse(prepay, out prepaySum);
            trip.Prepayment = prepaySum;
            trip.Note = tbMotivation.Text;
            trip.User = 1;

            //skapar objekt av klassen AddItems och skickar vidare modellen
            AddItems newItem = new AddItems();
            newItem.AddTrip(trip);
        }
    }
}
