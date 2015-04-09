using System.Data.Entity;
using System.Linq;

namespace DAL.UserRepository
{
    /// <summary>
    /// Contains methods for managing the Users table
    /// 
    /// Author: Linus
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

        /// <summary>
        /// Assign user to Boss tables (add as Boss)
        /// </summary>
        /// <param name="id">UserID</param>
        public static void AddUserAsBoss(int id)
        {
            using (var dbConnect = new DatabaseEntities())
            {
                var newBoss = new Boss {userID = id};
                dbConnect.Bosses.Add(newBoss);
                dbConnect.SaveChanges();
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
                var userToDelete = new User {userID = id};
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
                var thisUser = new User() {userID = id};
                dbConnect.Users.Attach(thisUser);
            }

            return thisUser;
        }

        /// <summary>
        /// Edit details of a specific user
        /// </summary>
        /// <param name="user">Object: User</param>
        public static void UpdateUser(User user)
        {
            using (var dbConnect = new DatabaseEntities())
            {
                dbConnect.Users.Attach(user);
                dbConnect.Entry(user).State = System.Data.Entity.EntityState.Modified;
                dbConnect.SaveChanges();
            }
        }

        /// <summary>
        /// Checks wheter a user is a Boss or not
        /// </summary>
        /// <param name="id">UserIDs</param>
        /// <returns>The specific Boss userID</returns>
        public static int IsUserBoss(int id)
        {
            using (var dbConnect = new DatabaseEntities())
            {
                var isBoss = dbConnect.Bosses.Where(a => a.userID == id)
                    .Select(x => x.userID)
                    .FirstOrDefault();
                
                return isBoss;
            }


        }
    }
}
