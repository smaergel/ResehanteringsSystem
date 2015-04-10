using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class VacationsRepository
    {
        DatabaseEntities _dbConnect = new DatabaseEntities();

        /// <summary>
        /// Add a new vacation to Vacations table
        /// </summary>
        /// <param name="vacation"></param>
        public void AddVacation(Vacation vacation)
        {
            _dbConnect.Vacations.Add(vacation);
            _dbConnect.SaveChanges();
        }


        /// <summary>
        /// Delete a verification in Verifications table
        /// </summary>
        /// <param name="vID"></param>
        public void DeleteVacation(int vID)
        {
            Vacation v = _dbConnect.Vacations.FirstOrDefault(x => x.VacationID == vID);
            _dbConnect.Vacations.Remove(v);
            _dbConnect.SaveChanges();
        }


        /// <summary>
        /// Delete a verification in Verifications table
        /// </summary>
        /// <param name="vacation"></param>
        public void DeleteVacation(Vacation vacation)
        {
            Vacation v = _dbConnect.Vacations.FirstOrDefault(x => x.VacationID == vacation.VacationID);
            _dbConnect.Vacations.Remove(v);
            _dbConnect.SaveChanges();
        }

        /// <summary>
        /// Update a verification in Verifications table
        /// </summary>
        /// <param name="vacation"></param>
        public void UpdateVacation(Vacation vacation)
        {
            Vacation v = _dbConnect.Vacations.FirstOrDefault(x => x.VacationID == vacation.VacationID);
            v.start = vacation.start;
            v.end = vacation.end;          
            v.tripID = vacation.tripID;
            _dbConnect.SaveChanges();
        }
    }
}
