using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Repositories.UserRepository;
using vITs.Models;

namespace vITs.Logic
{
    class AddUser
    {
        public static void AddNewUser(UserModel userModel)
        {
            var user = new User();
            user.firstname = userModel.firstname;
            user.lastname = userModel.lastname;
            user.password = userModel.password;
            user.email = userModel.email;
            user.phone = userModel.phone;
            user.boss = null;

            UserHandling.AddUser(user);
        }

        public static void AddBoss(UserModel userModel)
        {
            var user = new User();
            user.firstname = userModel.firstname;
            user.lastname = userModel.lastname;
            user.password = userModel.password;
            user.email = userModel.email;
            user.phone = userModel.phone;
            user.boss = null;

            UserHandling.AddUser(user);
            UserHandling.AddUserAsBoss(user);
        }

       
    }
}
