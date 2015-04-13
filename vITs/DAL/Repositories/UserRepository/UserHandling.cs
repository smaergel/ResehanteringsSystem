using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace DAL.Repositories.UserRepository
{
    /// <summary>
    /// Contains methods for managing the Users table
    /// 
    /// Author: Yvell/Waerner
    /// </summary>
    public static class UserHandling
    {
        /// <summary>
        /// Add a new user to Users table
        /// </summary>
        /// <param name="user">Object: User</param>
        public static void AddUser(User user)
        {
            using (var dbConnect = new DatabaseEntities())
            {
                dbConnect.Users.Add(user);
                dbConnect.SaveChanges();
            }
        }

        //Den kollar ifall emailen finns i databasen
        // ifall metoden returnerar null så finns inte användarnamnet i databasen.
        public static User ValidateIfEmailExists(string email)
        {
            using (var context = new DatabaseEntities())
            {
                return context.Users.FirstOrDefault(x =>
                    x.email.Equals(email));
            }
        }

        /// <summary>
        /// Assign user to Boss tables (add as Boss)
        /// </summary>
        /// <param name="user">Object: User</param>
        public static void AddUserAsBoss(User user)
        {
            using (var dbConnect = new DatabaseEntities())
            {
                var newBoss = new Boss { userID = user.userID };
                dbConnect.Bosses.Add(newBoss);
                dbConnect.SaveChanges();
            }
        }

        /// <summary>
        /// Remove a Users Boss privileges
        /// </summary>
        /// <param name="id">UserID</param>
        public static void RemoveBoss(int id)
        {
            using (var dbConnect = new DatabaseEntities())
            {
                var revokedBoss = new Boss { userID = id };
                dbConnect.Bosses.Attach(revokedBoss);
                dbConnect.Bosses.Remove(revokedBoss);
                dbConnect.SaveChanges();
            }
            
        }

        /// <summary>
        /// Returns a list of all bosses registered
        /// </summary>
        /// <returns>List of Object:Boss</returns>
        public static List<Boss> ListBosses()
        {
            using (var dbConnect = new DatabaseEntities())
            {
                var bosses = dbConnect.Bosses.ToList();

                return bosses;

            }
            
        }

        /// <summary>
        /// Delete a user using userID
        /// </summary>
        /// <param name="id">UserID</param>
        public static void DeleteUser(int id)
        {
            using (var dbConnect = new DatabaseEntities())
            {
                var userToDelete = new User { userID = id };
                dbConnect.Users.Attach(userToDelete);
                dbConnect.Users.Remove(userToDelete);
                dbConnect.SaveChanges();
            }
        }

        /// <summary>
        /// Get all info of a specific user
        /// (Good for editing details)
        /// </summary>
        /// <param name="id">UserID</param>
        /// <returns>Object: User (specified by ID)</returns>
        public static User GetUser(int id)
        {
            using (var dbConnect = new DatabaseEntities())
            {
                User user = dbConnect.Users.Find(id);

                return user;
            }
        }

        /// <summary>
        /// Edit details of a specific user
        /// 
        /// Use GetUser() to retrieve user for update
        /// </summary>
        /// <param name="user">The updated User object</param>
        public static void UpdateUser(User user)
        {
            using (var dbConnect = new DatabaseEntities())
            {
                var storedUser = (from s in dbConnect.Users
                                  where s.userID == user.userID
                                  select s).FirstOrDefault();

                if (storedUser == null) return;

                storedUser.firstname = user.firstname;
                storedUser.lastname = user.lastname;
                storedUser.phone = user.phone;
                storedUser.email = user.email;
                storedUser.boss = user.boss;
                storedUser.password = user.password;

                dbConnect.SaveChanges();
            }
            
        }
    }
}
