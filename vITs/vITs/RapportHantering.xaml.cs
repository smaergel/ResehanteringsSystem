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
            string state = stateSplit[1].Trim().Substring(0,stateSplit[1].Length-2);

            
            PdfDocument pdf = new PdfDocument();
            pdf.Info.Title = name;
            PdfPage pdfPage = pdf.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
            XFont minifont = new XFont("Verdana", 15);

            XImage img = XImage.FromFile("C:\\Users\\Slayer\\Desktop\\ResehanteringsSystem\\vITs\\vITs\\Graphics\\img.gif");
            graph.DrawImage(img, 10, 10, 80, 80);
            graph.DrawString("Anställd: " + name, font, XBrushes.Black,new XRect(0, -330, pdfPage.Width.Point,
            pdfPage.Height.Point), XStringFormat.Center);
            graph.DrawString("Id: " + id, minifont, XBrushes.Black, new XRect(0, -285, pdfPage.Width.Point,
            pdfPage.Height.Point), XStringFormat.Center);
            graph.DrawString("Destination: " + destination, minifont, XBrushes.Black, new XRect(0, -265, pdfPage.Width.Point,
            pdfPage.Height.Point), XStringFormat.Center);
            graph.DrawString("Datum: " + date, minifont, XBrushes.Black, new XRect(0, -245, pdfPage.Width.Point,
            pdfPage.Height.Point), XStringFormat.Center);
            graph.DrawString("Godkänt :" + state, minifont, XBrushes.Black, new XRect(0, -225, pdfPage.Width.Point,
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
            fillListData(HandleItems.GetTrips());
        }
        public void fillListData(IEnumerable<Object> query)
        {
            if (lvReports.Items.Count >= 1)
            {
                lvReports.Items.Clear();
            }
            var queryTrips = query;

                /*for (int i = 0; i < queryTrips.Count(); i++)
                {
                Type type = queryTrips.GetType().GetGenericArguments()[1];
                PropertyInfo propertyID = type.GetProperty("id");
                PropertyInfo propertyConsultant = type.GetProperty("consultant");
                PropertyInfo propertyDestination = type.GetProperty("destination");
                PropertyInfo propertyDate = type.GetProperty("date");
                PropertyInfo propertyState = type.GetProperty("status");
                object id = propertyID.GetValue(queryTrips.First(), null);
                object consultant = propertyConsultant.GetValue(queryTrips.First(), null);
                object destination = propertyDestination.GetValue(queryTrips.First(), null);
                object date = propertyDate.GetValue(queryTrips.First(), null);
                object state = propertyState.GetValue(queryTrips.First(), null);
                if ((bool)state == false) { state = "EJ OK"; } else { state = "OK"; }

                lvReports.Items.Add(new { id = id.ToString(), consultant = consultant.ToString(), destination = destination.ToString(), date = date.ToString().Substring(0, 10), status = state.ToString() });
                }*/
                foreach(var item in queryTrips)
                {
                    //Type type = item.GetType();
                    //var properties = type.GetProperties();

                    var id = item.GetType().GetProperty("id").GetValue(item).ToString();
                    var consultant = item.GetType().GetProperty("consultant").GetValue(item).ToString();
                    var destination = item.GetType().GetProperty("destination").GetValue(item).ToString();
                    var date = item.GetType().GetProperty("date").GetValue(item).ToString();
                    var state = item.GetType().GetProperty("status").GetValue(item);
                    if ((bool)state == false) { state = "EJ OK"; } else { state = "OK"; }

                    lvReports.Items.Add(new {id = id, consultant = consultant, destination = destination, date = date, status = state});
                }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //hello world
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void rbFilterAll_Checked(object sender, RoutedEventArgs e)
        {
            var query = HandleItems.GetTrips();
            fillListData(query);
        }

        private void rbFilterMonth_Checked(object sender, RoutedEventArgs e)
        {
            var query = HandleItems.GetTripsFiltered(-1);
            fillListData(query);
        }

        private void rbFilterQuater_Checked(object sender, RoutedEventArgs e)
        {
            var query = HandleItems.GetTripsFiltered(-3);
            fillListData(query);
        }

        private void rbFilterYear_Checked(object sender, RoutedEventArgs e)
        {
            var query = HandleItems.GetTripsFiltered(-12);
            fillListData(query);
        }
    }
}
