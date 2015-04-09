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
    /// Author: Linus
    /// </summary>
    class UserHandling
    {
        // ReSharper disable once FieldCanBeMadeReadOnly.Local
        DatabaseEntities _dbConnect = new DatabaseEntities();

        /// <summary>
        /// Add a new user to Users table
        /// </summary>
        /// <param name="user">Object: User</param>
        public void AddUser(User user)
        {
            _dbConnect.Users.Add(user);
            _dbConnect.SaveChanges();
        }

        /// <summary>
        /// Assign user to Boss tables (add as Boss)
        /// </summary>
        /// <param name="user">Object: User</param>
        public void AddUserAsBoss(User user)
        {
            var newBoss = new Boss {userID = user.userID};
            _dbConnect.Bosses.Add(newBoss);
            _dbConnect.SaveChanges();
        }

        /// <summary>
        /// Delete a user using userID
        /// </summary>
        /// <param name="id">UserID</param>
        public void DeleteUser(int id)
        {
            var userToDelete = new User {userID = id};
            _dbConnect.Users.Attach(userToDelete);
            _dbConnect.Users.Remove(userToDelete);
            _dbConnect.SaveChanges();
        }

        /// <summary>
        /// Get all info of a specific user
        /// (Good for editing details)
        /// </summary>
        /// <param name="id">UserID</param>
        /// <returns>Object: User (specified by ID)</returns>
        public User GetUser(int id)
        {
            var thisUser = new User() {userID = id};
            _dbConnect.Users.Attach(thisUser);

            return thisUser;
        }

        /// <summary>
        /// Edit details of a specific user
        /// </summary>
        /// <param name="user">Object: User</param>
        public void UpdateUser(User user)
        {
            _dbConnect.Users.Attach(user);
            _dbConnect.Entry(user).State = System.Data.Entity.EntityState.Modified;
            _dbConnect.SaveChanges();
        }
    }
}
