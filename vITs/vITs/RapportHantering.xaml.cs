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
            FillTripCbWithAllTrips();
        }

        private void ClearFieldsAndReloadBoxes()
        {
            
            tbPrepaySum.Clear();
            tbMotivation.Clear();
            cbCountryDeparture.Items.Clear();
            cbCountryArrival.Items.Clear();
            fillCbsWithCountries();
            FillTripCbWithAllTrips();


        }

        //Fyller cbs i skapa rapport fliken med länderna som finns i databasen (landnamn + id)
        private void fillCbsWithCountries()
        {
            var handle = new HandleItems();
            var countryCollection = handle.SendCountryList();
            foreach (var countryObject in countryCollection)
            {
                cbCountryArrival.Items.Add(countryObject.countryID + ". " + countryObject.country1);
                cbCountryDeparture.Items.Add(countryObject.countryID + ". " + countryObject.country1);
    
            }
            
        }

        private void FillTripCbWithAllTrips()
        {
            var handle = new HandleItems();
            var tripCollection = handle.SendTripList();
            foreach (var tripObject in tripCollection)
            {
                cbPickTripExpensesTab.Items.Add(tripObject.note);
            }
=======
>>>>>>> origin/master
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
            //validerar informationen som hämtats ut or boxarna
            if (Validering.CheckPrepaySum(trip.Prepayment))
            {
            //skapar objekt av klassen AddItems och skickar vidare modellen
            AddItems newItem = new AddItems();
            newItem.AddTrip(trip);
            ClearFieldsAndReloadBoxes();
            }
=======

>>>>>>> origin/master
        }
        
    }
}
