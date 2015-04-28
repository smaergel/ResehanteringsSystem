using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
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
            tripmodel.BossId = trip.boss;
            tripmodel.Status = trip.approved;
            return tripmodel;
            //för in datan i databasen
            //TripRepository.AddTrip(newTrip);

        }

        public static Trip TripModel2Trip(TripModel model)
        {
            var trip = new Trip();
            trip.origin = model.Origin;
            trip.destination = model.Destination;
            trip.start = model.Start;
            trip.end = model.End;
            trip.prepayment = model.Prepayment;
            trip.note = model.Note;
            trip.user = model.User;
            trip.boss = model.BossId;
            trip.approved = model.Status;
            return trip;
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

        public static Verification VerificationModel2Verification(VerificationModel vm)
        {
            var verification = new Verification();
            verification.cost = vm.cost;
            verification.date = vm.date;
            verification.expenceID = vm.expenceID;
            verification.note = vm.note;
            verification.path = vm.path;
            verification.tripID = vm.tripID;
            return verification;
        }

        public static VacationModel Vacation2VacationModel(Vacation vacation)
        {
            var vacationmodel = new VacationModel();
            vacationmodel.end = vacation.end;
            vacationmodel.start = vacation.start;
            vacationmodel.tripID = vacation.tripID;
            return vacationmodel;
           
        }

        public static Vacation VacationModel2Vacation(VacationModel vacationmodel)
        {
            var vacation = new Vacation();
            vacation.start = vacationmodel.start;
            vacation.end = vacationmodel.end;
            vacation.tripID = vacationmodel.tripID;
            return vacation;

        }


    }
}
