using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DAL;
<<<<<<< HEAD
using DAL.Repositories.UserRepository;
=======
>>>>>>> origin/master

namespace vITs
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
        }


        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            User newUser = new User
            {
                firstname = tbxFirstname.Text,
                lastname = tbxLastname.Text,
                phone = tbxTele.Text,
                email = tbxEmail.Text,
                password = tbxPasswordFirst.Text,
                boss = cbChef1.SelectedIndex
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //ID:t ska bytas ut mot inloggad användare.
            int id = 0;
            var changePass = UserHandling.GetUser(id);
            if (newPassword.Text.Equals(verifyNewPass) && oldPassword != newPassword)
            {
                changePass.password = newPassword.Text;
                UserHandling.UpdateUser(changePass);
            }
            else
            {
                {
                    Console.WriteLine("Lösenordet är redan i användning");
                }
            }
        }
    }
}
