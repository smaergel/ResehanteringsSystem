﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using vITs.Models;
using DAL.Repositories.TripRepository;

namespace vITs.Logic
{
    class AddItems
    {
        public static void AddTrip(TripModel trip)
        {
            //överför modellen TripModell till ett objekt av databastypen Trip
            var newTrip = new Trip();
            newTrip.origin = trip.Origin;
            newTrip.destination = trip.Destination;
            newTrip.start = trip.Start;
            newTrip.end = trip.End;
            newTrip.prepayment = trip.Prepayment;
            newTrip.note = trip.Note;
            newTrip.user = trip.User;
            newTrip.boss = trip.BossId;
            newTrip.approved = trip.Status;

            //för in datan i databasen
            TripRepository.AddTrip(newTrip);

        }

        public static void ApproveDenyReport(int id, int status)
        {
            
            TripRepository.ApproveDenyTrip(id, status);

        }

    }
}
