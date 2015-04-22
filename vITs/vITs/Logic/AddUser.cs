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

        public static void UpdateUser(int UserID, TextBox Tele, TextBox Email)
        {
            if (Validering.CheckIf2Empty(Tele, Email))
            {
                var user = UserHandling.GetUser(UserID);
                user.phone = Tele.Text;
      //          user.firstname = Address.Text;
                user.email = Email.Text;
                UserHandling.UpdateUser(user);
                MessageBox.Show("Uppgifter sparade");
                Tele.Text = "";
    //            Address.Text = "";
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

        public static void FillUserInformation(int UserID, TextBox Tele, TextBox Email)
        {
                var user = UserHandling.GetUser(UserID);
                Tele.Text = user.phone;
                Email.Text = user.email;
        }

        public static void DeleteUser(int userId, ComboBox cb)
        {
            var checkIfBoss = UserHandling.CheckIfBoss(userId);
            if (checkIfBoss != null)
            {
                UserHandling.DeleteBosses(userId);
                //UserHandling.DeleteUsers(userID);
                cb.Items.Clear();

            }
            UserHandling.DeleteUsers(userId);
            cb.Items.Clear();

        }

        public static void ClearText(TextBox Firstname, TextBox Lastname, TextBox Password, TextBox
        ConfirmPassword, TextBox Email, TextBox Tele, CheckBox cbx)
        {
            Firstname.Text = "";
            Lastname.Text = "";
            Password.Text = "";
            ConfirmPassword.Text = "";
            Email.Text = "";
            Tele.Text = "";
            cbx.IsChecked = false;
        }

    }
}
