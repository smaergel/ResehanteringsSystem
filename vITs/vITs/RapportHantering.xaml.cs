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
<<<<<<< HEAD
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
            
=======
>>>>>>> c1701da36c95cdd7ee9b41c0bd7517bcec2b0539
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
<<<<<<< HEAD
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
=======
            if ((User)Application.Current.Properties["currentUser"] != null)
            {
                User id = (User)Application.Current.Properties["currentUser"];
                lblloggedin.Content = id.lastname.ToString();
            }
            else
            {
                lblloggedin.Content = "Ej inloggad";
            }
>>>>>>> c1701da36c95cdd7ee9b41c0bd7517bcec2b0539
        }
        
    }
}
