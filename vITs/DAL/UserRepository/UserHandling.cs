using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UserRepository
{
    /// <summary>
    /// Contains methods for managing the Users table
    /// 
    /// Author: Yvell/Waerner
    /// </summary>
    class UserHandling
    {

        /// <summary>
        /// Add a new user to Users table
        /// </summary>
        /// <param name="user">Object: User</param>
        public void AddUser(User user)
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
        /// <param name="user">Object: User</param>
        public void AddUserAsBoss(User user)
        {
            using (var dbConnect = new DatabaseEntities())
            {
                var newBoss = new Boss { userID = user.userID };
                dbConnect.Bosses.Add(newBoss);
                dbConnect.SaveChanges();
            }
        }

        /// <summary>
        /// Delete a user using userID
        /// </summary>
        /// <param name="id">UserID</param>
        public void DeleteUser(int id)
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
        public User GetUser(int id)
        {
            using (var dbConnect = new DatabaseEntities())
            {
                var thisUser = new User() { userID = id };
                dbConnect.Users.Attach(thisUser);

                return thisUser;
            }
        }

        /// <summary>
        /// Edit details of a specific user
        /// 
        /// Use GetUser() to retrieve user for update
        /// </summary>
        /// <param name="user">The updated User object</param>
        public void UpdateUser(User user)
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
