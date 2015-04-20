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
            HandleItems.FillCbsWithCountries(cbCountryArrival, cbCountryDeparture);
            HandleItems.FillTripCbWithAllTrips(cbPickTripExpensesTab);
            HandleItems.FillBossList(cbChef);
        }

        private void ClearFieldsAndReloadBoxes()
        {
            
            tbPrepaySum.Clear();
            tbMotivation.Clear();
            cbCountryDeparture.Items.Clear();
            cbCountryArrival.Items.Clear();
            HandleItems.FillCbsWithCountries(cbCountryArrival, cbCountryDeparture);
            HandleItems.FillTripCbWithAllTrips(cbPickTripExpensesTab);


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
            trip.User = 1;  //HandleItems.GetCurrentUser();
            trip.Boss = (int) cbChef.SelectedValue;
            trip.Status = false;
            //validerar informationen som hämtats ut or boxarna
            if (Validering.CheckPrepaySum(trip.Prepayment))
            {
            //skapar objekt av klassen AddItems och skickar vidare modellen
            AddItems.AddTrip(trip);
            ClearFieldsAndReloadBoxes();
            }
        }

        private void btnApproveReport_Click(object sender, RoutedEventArgs e)
        {
            var reportId = 3; //lbReportsDenied.SelectedItem;
            AddItems.ApproveDenyReport(reportId, true);
        }

        private void btnShowOwnReports_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
