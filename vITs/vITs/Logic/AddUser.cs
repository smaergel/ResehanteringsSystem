using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
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

        public static void UpdateUser(int UserID, TextBox Tele, TextBox Address, TextBox Email)
        {
            if (Validering.CheckIf3Empty(Tele, Address, Email))
            {
                var user = UserHandling.GetUser(UserID);
                user.phone = Tele.Text;
                user.firstname = Address.Text;
                user.email = Email.Text;
                UserHandling.UpdateUser(user);
                MessageBox.Show("Uppgifter sparade");
                Tele.Text = "";
                Address.Text = "";
                Email.Text = "";
            }
        }

        public static void ChangePassword(int user, TextBox newPasswordOne, TextBox newPasswordTwo, TextBox OldPassword)
        {
            if (Validering.CheckIf3Empty(newPasswordOne, newPasswordTwo, OldPassword))
            {
                var userNow = UserHandling.GetUser(user);
                if (userNow.password != OldPassword.Text)
                {
                    MessageBox.Show("Du har angivit fel lösenord");
                }

                else if (newPasswordOne.Text != newPasswordTwo.Text)
                {
                    MessageBox.Show("Lösenorden stämmer inte överens");
                }

                else
                {
                    userNow.password = newPasswordOne.Text;
                    UserHandling.UpdateUser(userNow);
                    MessageBox.Show("Lösenordet har ändrats");
                    newPasswordOne.Text = "";
                    newPasswordTwo.Text = "";
                    OldPassword.Text = "";
                }
            }
        }

        public static void FillUserInformation(int UserID, TextBox Tele, TextBox Address, TextBox Email)
        {
                var user = UserHandling.GetUser(UserID);
                Tele.Text = user.phone;
                Address.Text = user.firstname;
                Email.Text = user.email;
        }

    }
}
