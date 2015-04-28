using System.Collections.Generic;
using System.Linq;

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

        public static List<User> GetUsers()
        {
            using (var dbConnect = new DatabaseEntities())
            {
                List<User> userList = new List<User>();
                var query = from u in dbConnect.Users
                            select u;
                foreach (User u in query)
                {
                    userList.Add(u);
                }
                return userList;

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

        public static List<User> getBosses()
        {
            using (var dbConnect = new DatabaseEntities())
            {
                List<User> bossList = new List<User>();
                var query = from u in dbConnect.Users
                            join b in dbConnect.Bosses on u.userID equals b.userID
                            select u;
                foreach (User u in query)
                {
                    bossList.Add(u);
                }
                return bossList;

            }
        }

        public static Boss CheckIfBoss(int id)
        {
            using (var dbConnect = new DatabaseEntities())
            {
                return dbConnect.Bosses.FirstOrDefault(x =>
                x.userID.Equals(id));
            }

        }

        public static void DeleteBosses(int bID)
        {
            using (var context = new DatabaseEntities())
            {
                Boss b = context.Bosses.FirstOrDefault(x => x.userID == bID);
                context.Bosses.Remove(b);
                context.SaveChanges();
            }
        }

        public static void DeleteUsers(int uID)
        {
            using (var context = new DatabaseEntities())
            {
                User u = context.Users.FirstOrDefault(x => x.userID == uID);
                context.Users.Remove(u);
                context.SaveChanges();
            }
        }

    }
}
