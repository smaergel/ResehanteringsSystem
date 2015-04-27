using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VerificationRepository
    {
        /// <summary>
        /// Add a new verification to Verifications table
        /// </summary>
        /// <param name="verification">Object: Verification</param>
        public static void AddVerification(Verification verification)
        {
            using (var context = new DatabaseEntities())
            {
                context.Verifications.Add(verification);
                context.SaveChanges();
            }
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
        public static void UpdateVerification(int vID, int expenceID, int cost, string path, DateTime date, string note, int id)
        {
            using (var context = new DatabaseEntities())
            {
                Verification v = context.Verifications.FirstOrDefault(x => x.verificationID == vID);

                v.expenceID = expenceID;
                v.cost = cost;
                v.path = path;
                v.date = date;
                v.note = note;
                v.tripID = id;
                context.SaveChanges();
            }
        }


        /// <summary>
        /// Update verification in Verifications table
        /// </summary>
        /// <param name="verification"></param>
        public static void UpdateVerification2(Verification verification)
        {
            using (var context = new DatabaseEntities())
            {
                Verification v =
                context.Verifications.FirstOrDefault(x => x.verificationID == verification.verificationID);
                v.expenceID = verification.expenceID;
                v.cost = verification.cost;
                v.path = verification.path;
                v.date = verification.date;
                v.note = verification.note;
                v.tripID = verification.tripID;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Delete a verification in Verifications table
        /// </summary>
        /// <param name="vID"></param>
        public static void DeleteVerification(int vID)
        {
            using (var context = new DatabaseEntities())
            {
                Verification v = context.Verifications.FirstOrDefault(x => x.verificationID == vID);
                context.Verifications.Remove(v);
                context.SaveChanges();
            }
        }


        /// <summary>
        /// Delete a verification in Verifications table
        /// </summary>
        /// <param name="verification"></param>
        public static void DeleteVerification(Verification verification)
        {
            using (var context = new DatabaseEntities())
            {
                Verification v =
                context.Verifications.FirstOrDefault(x => x.verificationID == verification.verificationID);
                context.Verifications.Remove(v);
                context.SaveChanges();
            }
        }



    }
}
