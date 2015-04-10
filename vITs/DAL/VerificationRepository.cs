using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VerificationRepository
    {
        DatabaseEntities _dbConnect = new DatabaseEntities();


        /// <summary>
        /// Add a new verification to Verifications table
        /// </summary>
        /// <param name="verification">Object: Verification</param>
        public void AddVerification(Verification verification)
        {
            _dbConnect.Verifications.Add(verification);
            _dbConnect.SaveChanges();
        }


        /// <summary>
        /// Update verification in Verifications table
        /// </summary>
        /// <param name="vID"></param>
        /// <param name="expenceID"></param>
        /// <param name="cost"></param>
        /// <param name="path"></param>
        /// <param name="date"></param>
        /// <param name="note"></param>
        /// <param name="id"></param>
        public void UpdateVerification(int vID, int expenceID, int cost, string path, DateTime date, string note, int id)
        {
            Verification v = _dbConnect.Verifications.FirstOrDefault(x => x.verificationID == vID);

            v.expenceID = expenceID;
            v.cost = cost;
            v.path = path;
            v.date = date;
            v.note = note;
            v.tripID = id;
            _dbConnect.SaveChanges();
        }


        /// <summary>
        /// Update verification in Verifications table
        /// </summary>
        /// <param name="verification"></param>
        public void UpdateVerification2(Verification verification)
        {
            Verification v = _dbConnect.Verifications.FirstOrDefault(x => x.verificationID == verification.verificationID);
            v.expenceID = verification.expenceID;
            v.cost = verification.cost;
            v.path = verification.path;
            v.date = verification.date;
            v.note = verification.note;
            v.tripID = verification.tripID;
            _dbConnect.SaveChanges();
        }

        /// <summary>
        /// Delete a verification in Verifications table
        /// </summary>
        /// <param name="vID"></param>
        public void DeleteVerification(int vID)
        {
            Verification v = _dbConnect.Verifications.FirstOrDefault(x => x.verificationID == vID);
            _dbConnect.Verifications.Remove(v);
            _dbConnect.SaveChanges();
        }


        /// <summary>
        /// Delete a verification in Verifications table
        /// </summary>
        /// <param name="vID"></param>
        public void DeleteVerification(Verification verification)
        {
            Verification v = _dbConnect.Verifications.FirstOrDefault(x => x.verificationID == verification.verificationID);
            _dbConnect.Verifications.Remove(v);
            _dbConnect.SaveChanges();
        }
    }
}
