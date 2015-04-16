using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
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
            User user = new User();
            user.firstname = userModel.firstname;
            user.lastname = userModel.lastname;
            user.password = userModel.password;
            user.email = userModel.email;
            user.phone = userModel.phone;
            user.boss = userModel.boss;

            UserHandling.AddUser(user);
        }

        public static void AddBoss(UserModel userModel)
        {
            User user = new User();
            user.firstname = userModel.firstname;
            user.lastname = userModel.lastname;
            user.password = userModel.password;
            user.email = userModel.email;
            user.phone = userModel.phone;
            user.boss = userModel.boss;

            UserHandling.AddUser(user);
            UserHandling.AddUserAsBoss(user);
        }

        public static bool validateAddUser(TextBox fn, TextBox ln, TextBox e, TextBox phon,
        TextBox pw, TextBox pw2, ComboBox cb, CheckBox cbx)
        {
            if (fn.Text == "" || ln.Text == "" || e.Text == "" || phon.Text == ""
            || pw.Text == "" || pw2.Text == "" || cb.SelectedItem == null && cbx.IsChecked == false)
            {
                System.Windows.MessageBox.Show("Fyll i alla fält");
                return false;
            }
            if (pw.Text != pw2.Text)
            {
                System.Windows.MessageBox.Show("Lösenord måste matcha");
                return false; 
            }
            return true;
        }
    }
}
