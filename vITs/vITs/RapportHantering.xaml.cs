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
using DAL.Repositories.CountryRepository;

namespace vITs
{
    /// <summary>
    /// Interaction logic for RapportHantering.xaml
    /// </summary>
    public partial class RapportHantering : Window
    {
        public List<FullTrip> fulltrips;
        public Dictionary<string, Vacation> dic;
        public RapportHantering()
        {
            InitializeComponent();
            fillCbsWithCountries();
            HandleItems.FillBossList(cbBosses);
            LoadReseUtlägg();
            
            
        }

        private void ClearFieldsAndReloadBoxes()
        {
            
            tbPrepaySum.Clear();
            tbMotivation.Clear();
            cbCountryDeparture.Items.Clear();
            cbCountryArrival.Items.Clear();
            fillCbsWithCountries();
            
            


        }

        private void LoadReseUtlägg()
        {
            fulltrips = Serializer.Load();
            cbPickTripExpensesTab.ItemsSource = fulltrips;
            cbKostnTyp.ItemsSource = ExpencesRepository.getAll();
  
            
        }

        //Fyller cbs i skapa rapport fliken med länderna som finns i databasen (landnamn + id)
        private void fillCbsWithCountries()
        {
            var countryCollection = CountryRepository.GetAllCountries();
            foreach (var countryObject in countryCollection)
            {
                cbCountryArrival.Items.Add(countryObject);
                cbCountryDeparture.Items.Add(countryObject);
            }
            
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            var realtrip = new Trip();
            
            var trip = new TripModel();
            //fyller modellen med information
            realtrip.origin = (int)cbCountryArrival.SelectedValue;
            realtrip.destination = (int)cbCountryDeparture.SelectedValue;
           

            realtrip.start = (DateTime) dpStartDate.SelectedDate;
            realtrip.end = (DateTime) dpEndDate.SelectedDate;
            var prepay = tbPrepaySum.Text;
            int prepaySum;
            int.TryParse(prepay, out prepaySum);
            realtrip.prepayment = prepaySum;
            realtrip.note = tbMotivation.Text;
            realtrip.user = 1;
            realtrip.boss = (int)cbBosses.SelectedItem;
            //validerar informationen som hämtats ut or boxarna
            if (Validering.CheckPrepaySum((int)realtrip.prepayment))
            {
                var FullTrip = new FullTrip();
                FullTrip.myTrip = ModelTransformer.Trip2TripModel(realtrip);
            
                foreach(Vacation item in lbVacations.Items)
                {
                    FullTrip.myVacation.Add(ModelTransformer.Vacation2VacationModel(item));
                }
                
                //              DB!!!
                //TripRepository.AddTrip(realtrip);
                //foreach(var item in FullTrip.myVacation)
                //{
                //    var vacation = ModelTransformer.VacationModel2Vacation(item);
                //    vacation.tripID = realtrip.tripID;
                //    VacationsRepository.AddVacation(vacation);
                //}

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

                lbVacations.Items.Add(vacDate);
                
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

        private void dpEndDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            resetVacations();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void cbPickTripExpensesTab_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }



        private void btnAddVerification_Click(object sender, RoutedEventArgs e)
        {
            double price;
            Double.TryParse(tbCost.Text, out price);
            FullTrip selectedItem = (FullTrip)cbPickTripExpensesTab.SelectedItem;
            var verification = new VerificationModel();
            verification.cost = price;
            verification.note = tbCostNotes.Text;
            fulltrips[cbPickTripExpensesTab.SelectedIndex].myVerifications.Add(verification);

            Serializer.Overwrite(fulltrips);
            //List<FullTrip> test = new List<FullTrip>();
            //test = (List<FullTrip>)cbPickTripExpensesTab.ItemsSource;
        }




    }
}
