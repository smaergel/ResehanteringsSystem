using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UserRepository
{
    /// <summary>
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
        }

        /// <summary>
        /// Assign user to Boss tables (add as Boss)
        /// </summary>
        /// <param name="user">Object: User</param>
        public void AddUserAsBoss(User user)
        {
            var newBoss = new Boss {userID = user.userID};
            _dbConnect.Bosses.Add(newBoss);
        }
    }
}
