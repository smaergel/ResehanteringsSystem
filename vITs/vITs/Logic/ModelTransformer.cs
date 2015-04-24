using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using vITs.Models;
using DAL.Repositories.TripRepository;

namespace vITs.Logic
{
    public static class ModelTransformer
    {
        public static TripModel Trip2TripModel(Trip trip)
        {
            //överför modellen TripModell till ett objekt av databastypen Trip
            var tripmodel = new TripModel();
            tripmodel.Origin = trip.origin;
            tripmodel.Destination = trip.destination;
            tripmodel.Start = trip.start;
            tripmodel.End = trip.end;
            tripmodel.Prepayment = (int)trip.prepayment;
            tripmodel.Note = trip.note;
            tripmodel.User = trip.user;

            return tripmodel;
            //för in datan i databasen
            //TripRepository.AddTrip(newTrip);

        }

        public static VerificationModel Verification2VerificationModel(Verification verification)
        {
            var verificationmodel = new VerificationModel();
            verificationmodel.cost = verification.cost;
            verificationmodel.date = verification.date;
            verificationmodel.expenceID = verification.expenceID;
            verificationmodel.note = verification.note;
            verificationmodel.path = verification.path;
            verificationmodel.tripID = verification.tripID;
            return verificationmodel;
        }

        public static VacationModel Vacation2VacationModel(Vacation vacation)
        {
            var vacationmodel = new VacationModel();
            vacationmodel.end = vacation.end;
            vacationmodel.start = vacation.start;
            vacationmodel.tripID = vacation.tripID;
            return vacationmodel;
           
        }



    }
}
