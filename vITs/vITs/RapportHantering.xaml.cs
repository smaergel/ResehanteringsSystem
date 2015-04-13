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
<<<<<<< HEAD
=======
using vITs.Logic;
using vITs.Models;
>>>>>>> origin/master

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
        }

        //Fyller cbs i skapa rapport fliken med länderna som finns i databasen (landnamn + id)
        private void fillCbsWithCountries()
        {
            //var CountryCollection = ;
            /* foreach (var countryObject in CountryCollection)
            {
                cbCountryArrival.Items.Add(countryObject);
                cbCountryDeparture.Items.Add(countryObject);
    
            }*/
            
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            //skapar en modell av typen resa
            var trip = new TripModel();
            //fyller modellen med information
            trip.Origin = cbCountryDeparture.SelectedIndex;
            trip.Destination = cbCountryArrival.SelectedIndex;
            trip.Start = (DateTime) dpStartDate.SelectedDate;
            trip.End = (DateTime) dpEndDate.SelectedDate;
            var prepay = tbPrepaySum.Text;
            int prepaySum;
            int.TryParse(prepay, out prepaySum);
            trip.Prepayment = prepaySum;
            trip.Note = tbMotivation.Text;

            //skapar objekt av klassen AddItems och skickar vidare modellen
            AddItems newItem = new AddItems();
            newItem.AddTrip(trip);
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            if ((User)Application.Current.Properties["currentUser"] != null)
            {
                User id = (User)Application.Current.Properties["currentUser"];
                lblloggedin.Content = id.lastname.ToString();
            }
            else
            {
                lblloggedin.Content = "Ej inloggad";
            }
        }
        
    }
}
