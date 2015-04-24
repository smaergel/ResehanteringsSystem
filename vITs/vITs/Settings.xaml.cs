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
using vITs.Logic;
using vITs.Models;

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
            HandleItems.FillBossList(cbChef);
            FillUserInformation();
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var oPass = oldPassword;
           // var nPass = newPassword;
           // var vNewPass = verifyNewPass;

           // if (newPassword.Equals(verifyNewPass) && oldPassword != newPassword) ;
            //{
                
            //}
        }

        public void FillUserInformation()
        {
            AddUser.FillUserInformation(HandleItems.GetCurrentUserId(), tbxUpdatePhone, tbxUpdateAddress, tbxUpdateEmail);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            UserModel userModel = new UserModel(tbxFirstName.Text, tbxLastName.Text,
            tbxPasswordFirst.Text, tbxEmail.Text, tbxTele.Text);

            if (cbxBoss.IsChecked == true)
            {
                AddUser.AddBoss(userModel);
            }
            else
            {
                AddUser.AddNewUser(userModel);
            }
           
        }

        private void cbxBoss_Checked(object sender, RoutedEventArgs e)
        {
            cbChef.IsEnabled = false;
        }

        private void cbxBoss_Unchecked(object sender, RoutedEventArgs e)
        {
            cbChef.IsEnabled = true;
        }

       
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddUser.UpdateUser(HandleItems.GetCurrentUserId(), tbxUpdatePhone, tbxUpdateAddress, tbxUpdateEmail);
            FillUserInformation();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddUser.ChangePassword(HandleItems.GetCurrentUserId(),tbxNewPassword1, tbxNewPassword2, tbxOldPassword);
        }
    }
}
