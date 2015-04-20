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
using DAL.Repositories.TripRepository;

namespace vITs
{
    /// <summary>
    /// Interaction logic for RapportHantering.xaml
    /// </summary>
    public partial class RapportHantering : Window
    {
        public Dictionary<string, Vacation> dic;
        public RapportHantering()
        {
            InitializeComponent();
<<<<<<< HEAD
            fillCbsWithCountries();
            FillTripCbWithAllTrips();
            //dic = new Dictionary<string,Vacation>();
   
            
            
=======
            HandleItems.FillCbsWithCountries(cbCountryArrival, cbCountryDeparture);
            HandleItems.FillTripCbWithAllTrips(cbPickTripExpensesTab);
            HandleItems.FillBossList(cbChef);
>>>>>>> origin/master
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
            var realtrip = new Trip();
            
            
            var trip = new TripModel();
            //fyller modellen med information
            realtrip.origin = cbCountryDeparture.SelectedIndex + 1;
            realtrip.destination = cbCountryArrival.SelectedIndex + 1;
            realtrip.start = (DateTime) dpStartDate.SelectedDate;
            realtrip.end = (DateTime) dpEndDate.SelectedDate;
            var prepay = tbPrepaySum.Text;
            int prepaySum;
            int.TryParse(prepay, out prepaySum);
<<<<<<< HEAD
            realtrip.prepayment = prepaySum;
            realtrip.note = tbMotivation.Text;
            realtrip.user = 1;
=======
            trip.Prepayment = prepaySum;
            trip.Note = tbMotivation.Text;
            trip.User = 1;  //HandleItems.GetCurrentUser();
            trip.Boss = (int) cbChef.SelectedValue;
            trip.Status = false;
>>>>>>> origin/master
            //validerar informationen som hämtats ut or boxarna
            if (Validering.CheckPrepaySum((int)realtrip.prepayment))
            {
                var FullTrip = new FullTrip();
                FullTrip.myTrip = ModelTransformer.Trip2TripModel(realtrip);
                Serializer.Save(FullTrip);
                ClearFieldsAndReloadBoxes();
            }
        }

        private void btnAddBreak_Click(object sender, RoutedEventArgs e)
        {
             dpVacationEnd.BorderBrush = Brushes.Gray;
            dpVacationStart.BorderBrush = Brushes.Gray;
            dpStartDate.BorderBrush = Brushes.Gray;
            dpEndDate.BorderBrush = Brushes.Gray;
            var Go = true;
            var vacDate = new Vacation
            {
                start = dpVacationStart.SelectedDate.GetValueOrDefault(),
                end = dpVacationEnd.SelectedDate.GetValueOrDefault(),
            };
            if(vacDate.start > vacDate.end) 
            {
                dpVacationStart.BorderBrush = Brushes.Red;
                dpVacationEnd.BorderBrush = Brushes.Red;
                Go = false;
            }

            
            if(vacDate.start < dpStartDate.SelectedDate.GetValueOrDefault())
            {
                dpVacationStart.BorderBrush = Brushes.Red;
                Go = false;
            }

                
            if(vacDate.end > dpEndDate.SelectedDate.GetValueOrDefault())
            {
                dpVacationEnd.BorderBrush = Brushes.Red;
                Go = false;
            }
            
                            
            
               
            if(Go)
            {
<<<<<<< HEAD

                lbVacations.Items.Add(vacDate);
                
=======
            //skapar objekt av klassen AddItems och skickar vidare modellen
            AddItems.AddTrip(trip);
            ClearFieldsAndReloadBoxes();
>>>>>>> origin/master
            }
                
    
            
        }

        private void dpStartDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            resetVacations();
        }

        public void resetVacations()
        {
            lbVacations.Items.Clear();
        }

<<<<<<< HEAD
        private void dpEndDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            resetVacations();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }


=======
        private void btnApproveReport_Click(object sender, RoutedEventArgs e)
        {
            var reportId = 3; //lbReportsDenied.SelectedItem;
            AddItems.ApproveDenyReport(reportId, true);
        }

        private void btnShowOwnReports_Click(object sender, RoutedEventArgs e)
        {

        }
>>>>>>> origin/master
    }
}
