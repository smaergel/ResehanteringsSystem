using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VacationsRepository
    {
        /// <summary>
        /// Add a new vacation to Vacations table
        /// </summary>
        /// <param name="vacation"></param>
        public static void AddVacation(Vacation vacation)
        {
            using (var context = new DatabaseEntities())
            {
                context.Vacations.Add(vacation);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Delete a verification in Verifications table
        /// </summary>
        /// <param name="vID"></param>
        public static void DeleteVacation(int vID)
        {
            using (var context = new DatabaseEntities())
            {
                Vacation v = context.Vacations.FirstOrDefault(x => x.VacationID == vID);
                context.Vacations.Remove(v);
                context.SaveChanges();
            }
        }


        /// <summary>
        /// Delete a verification in Verifications table
        /// </summary>
        /// <param name="vacation"></param>
        public static void DeleteVacation(Vacation vacation)
        {
            using (var context = new DatabaseEntities())
            {
                Vacation v = context.Vacations.FirstOrDefault(x => x.VacationID == vacation.VacationID);
                context.Vacations.Remove(v);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Update a verification in Verifications table
        /// </summary>
        /// <param name="vacation"></param>
        public static void UpdateVacation(Vacation vacation)
        {
            using (var context = new DatabaseEntities())
            {
                Vacation v = context.Vacations.FirstOrDefault(x => x.VacationID == vacation.VacationID);
                v.start = vacation.start;
                v.end = vacation.end;
                v.tripID = vacation.tripID;
                context.SaveChanges();
            }
        }
    }
}
