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
            FillUserInformation();
            FillUserList();
        }

        public void FillUserList()
        {
            var handle = new HandleItems();
            var userList = handle.SendUserList();
            foreach (var user in userList)
            {
                cbUser.Items.Add(user.userID + ". " + user.firstname + " " + user.lastname);
            }
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
            AddUser.FillUserInformation(HandleItems.GetCurrentUserId(), tbxUpdatePhone, tbxUpdateEmail);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            UserModel userModel = new UserModel(tbxFirstName.Text, tbxLastName.Text,
                       tbxPasswordFirst.Password, tbxEmail.Text, tbxTele.Text);
            if (AddUser.ValidateAddUser(tbxFirstName, tbxLastName,
            tbxPasswordFirst, tbxPasswordSecond, tbxEmail, tbxTele))
            {
                if (cbxBoss.IsChecked == true)
                {
                    AddUser.AddBoss(userModel);
                    AddUser.ClearText(tbxFirstName, tbxLastName,
                        tbxPasswordFirst, tbxPasswordSecond, tbxEmail, tbxTele, cbxBoss);
                    cbUser.Items.Clear();
                    FillUserList();

                }
                else
                {

                    AddUser.AddNewUser(userModel);
                    AddUser.ClearText(tbxFirstName, tbxLastName,
                        tbxPasswordFirst, tbxPasswordSecond, tbxEmail, tbxTele, cbxBoss);
                    cbUser.Items.Clear();
                    FillUserList();
                }
            }
        }

  
       
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddUser.UpdateUser(HandleItems.GetCurrentUserId(), tbxUpdatePhone, tbxUpdateEmail);
            FillUserInformation();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddUser.ChangePassword(HandleItems.GetCurrentUserId(),tbxNewPassword1, tbxNewPassword2, tbxOldPassword);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var userID = cbUser.SelectedItem.ToString().Split('.')[0];
            AddUser.DeleteUser(Convert.ToInt16(userID), cbUser);
            FillUserList();
        }
    }
}
