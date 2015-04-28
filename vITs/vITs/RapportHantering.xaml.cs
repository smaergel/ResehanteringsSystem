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
using DAL.Repositories.UserRepository;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Charting;
using PdfSharp.Internal;
using System.Drawing;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;

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
            HandleItems.FillBossList(cbBosses);
            LoadReseUtlägg();
            HandleItems.FillCbsWithCountries(cbCountryArrival, cbCountryDeparture);
            HandleItems.FillListBoxWithAwaitingApproval(lbReportsDenied);

            if (HandleItems.GetCurrentUserId() == 0)
            {
                tbSearchAnstIdDenied.IsEnabled = false;
                btnGetReportsDenied.IsEnabled = false;
                tbSearchAnstIdApproved.IsEnabled = false;
                btnGetReportsApproved.IsEnabled = false;
                anvInstallningar.IsEnabled = false;
            }
        }

        private void ClearFieldsAndReloadBoxes()
        {

            tbPrepaySum.Clear();
            tbMotivation.Clear();
            cbCountryDeparture.Items.Clear();
            cbCountryArrival.Items.Clear();
            lbReportsDenied.Items.Clear();
            HandleItems.FillListBoxWithAwaitingApproval(lbReportsDenied);
            HandleItems.FillCbsWithCountries(cbCountryArrival, cbCountryDeparture);
            


        }


        private void LoadReseUtlägg()
        {
            fulltrips = Serializer.Load();
            cbPickTripExpensesTab.ItemsSource = fulltrips;
            cbKostnTyp.ItemsSource = ExpencesRepository.getAll();
  
            
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


            //fyller modellen med information
            realtrip.origin = cbCountryDeparture.SelectedIndex + 1;
            realtrip.destination = cbCountryArrival.SelectedIndex + 1;
            realtrip.start = (DateTime)dpStartDate.SelectedDate;
            realtrip.end = (DateTime)dpEndDate.SelectedDate;
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
            if (vacDate.start > vacDate.end)
            {
                dpVacationStart.BorderBrush = Brushes.Red;
                dpVacationEnd.BorderBrush = Brushes.Red;
                Go = false;
            }


            if (vacDate.start < dpStartDate.SelectedDate.GetValueOrDefault())
            {
                dpVacationStart.BorderBrush = Brushes.Red;
                Go = false;
            }


            if (vacDate.end > dpEndDate.SelectedDate.GetValueOrDefault())
            {
                dpVacationEnd.BorderBrush = Brushes.Red;
                Go = false;
            }
            if(Go)




            if (Go)
            {

                lbVacations.Items.Add(vacDate);

            }



        }

        private void dpStartDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            ResetVacations();
        }

        public void ResetVacations()
        {
            lbVacations.Items.Clear();
        }

        private void dpEndDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            ResetVacations();
        }


        private void cbPickTripExpensesTab_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnApprove_Click(object sender, RoutedEventArgs e)
        {
            //kod behöver förändras när objekt i listan finns så allt blir rätt.
            var report = (TripModel)lbReportsDenied.SelectedItem;

            AddItems.ApproveDenyReport(report.TripId, 1);
            ClearFieldsAndReloadBoxes();
        }
        private void btnDeny_Click(object sender, RoutedEventArgs e)
        {
            //kod behöver förändras när objekt i listan finns så allt blir rätt.
            var report = (TripModel)lbReportsDenied.SelectedItem;

            AddItems.ApproveDenyReport(report.TripId, 0);
            ClearFieldsAndReloadBoxes();
        }
        private void anvInstalnningar_Click(object sender, RoutedEventArgs e)
        {
            var installning = new Settings();
            installning.Show();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }



        private void btnShowOwnReports_Click(object sender, RoutedEventArgs e)
        {
            var row = lvReports.SelectedItem.ToString();
            string[] col = row.Split(',');

            string id = Regex.Match(col[0], @"\d+").Value;
            string[] nameSplit = col[1].Split('=');
            string name = nameSplit[1].Trim();
            string[] destinationSplit = col[2].Split('=');
            string destination = destinationSplit[1].Trim();
            string[] dateSplit = col[3].Split('=');
            string date = dateSplit[1].Trim();
            string[] stateSplit = col[4].Split('=');
            string state = stateSplit[1].Trim().Substring(0, stateSplit[1].Length - 2);


            PdfDocument pdf = new PdfDocument();
            pdf.Info.Title = name;
            PdfPage pdfPage = pdf.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
            XFont minifont = new XFont("Verdana", 15);

            XImage img = XImage.FromFile("C:\\Users\\Peter\\Documents\\GitHub\\ResehanteringsSystem\\vITs\\vITs\\Graphics\\pdfImage.gif");
            graph.DrawImage(img, 10, 10, 80, 80);
            graph.DrawString("Anställd: " + name, font, XBrushes.Black, new XRect(0, -330, pdfPage.Width.Point,
            pdfPage.Height.Point), XStringFormat.Center);
            graph.DrawString("Id: " + id, minifont, XBrushes.Black, new XRect(0, -285, pdfPage.Width.Point,
            pdfPage.Height.Point), XStringFormat.Center);
            graph.DrawString("Destination: " + destination, minifont, XBrushes.Black, new XRect(0, -265, pdfPage.Width.Point,
            pdfPage.Height.Point), XStringFormat.Center);
            graph.DrawString("Datum: " + date, minifont, XBrushes.Black, new XRect(0, -245, pdfPage.Width.Point,
            pdfPage.Height.Point), XStringFormat.Center);
            graph.DrawString("Status :" + state, minifont, XBrushes.Black, new XRect(0, -225, pdfPage.Width.Point,
            pdfPage.Height.Point), XStringFormat.Center);
            string pdfFilename = id + ".pdf";
            if (pdfFilename != "")
            {
                pdf.Save(pdfFilename);
            }
            Process.Start(pdfFilename);
        }

        private void btnGetOwnReports_Click(object sender, RoutedEventArgs e)
        {
            FillListData(HandleItems.GetTrips());
        }
        public void FillListData(IEnumerable<Object> query)
        {
            if (lvReports.Items.Count >= 1)
            {
                lvReports.Items.Clear();
            }
            var queryTrips = HandleItems.GetTrips();

            foreach (var item in queryTrips)
            {
                //Type type = item.GetType();
                //var properties = type.GetProperties();

                var id = item.GetType().GetProperty("id").GetValue(item).ToString();
                var consultant = item.GetType().GetProperty("consultant").GetValue(item).ToString();
                var destination = item.GetType().GetProperty("destination").GetValue(item).ToString();
                var date = item.GetType().GetProperty("date").GetValue(item).ToString();
                var state = item.GetType().GetProperty("status").GetValue(item);
                if ((int) state == 2)
                {
                    state = "EJ OK";
                }
                else if ((int)state == 1)
                {
                    state = "OK";
                }
                else
                {
                    state = "Väntar";
                }

                lvReports.Items.Add(new { id, consultant, destination, date, status = state });
            }
        }


        private void rbFilterAll_Checked(object sender, RoutedEventArgs e)
        {
            var query = HandleItems.GetTrips();
            FillListData(query);
        }

        private void rbFilterMonth_Checked(object sender, RoutedEventArgs e)
        {
            var query = HandleItems.GetTripsFiltered(-1);
            FillListData(query);
        }

        private void rbFilterQuater_Checked(object sender, RoutedEventArgs e)
        {
            var query = HandleItems.GetTripsFiltered(-3);
            FillListData(query);
        }

        private void rbFilterYear_Checked(object sender, RoutedEventArgs e)
        {
            var query = HandleItems.GetTripsFiltered(-12);
            FillListData(query);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
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
