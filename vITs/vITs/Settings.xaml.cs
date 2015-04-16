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
            FillBossList();
        }

        private void FillBossList()
        {
            var handle = new HandleItems();
            var bossList = handle.SendBossList();
            foreach (var boss in bossList)
            {
                cbChef.Items.Add(boss.userID + ". " + boss.firstname + " " + boss.lastname);
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

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (AddUser.validateAddUser(tbxFirstName, tbxLastName,
                tbxPasswordFirst, tbxPasswordSecond, tbxEmail, tbxTele, cbChef, cbxBoss))
            {


                if (cbxBoss.IsChecked == true)
                {

                    UserModel bossModel = new UserModel(tbxFirstName.Text, tbxLastName.Text,
                        tbxPasswordFirst.Text, tbxEmail.Text, tbxTele.Text);

                    AddUser.AddBoss(bossModel);
                }
                else
                {
                    var BossID = cbChef.SelectedItem.ToString().Split('.')[0];
                    UserModel userModel = new UserModel(tbxFirstName.Text, tbxLastName.Text,
                        tbxPasswordFirst.Text, tbxEmail.Text, tbxTele.Text, Convert.ToInt16(BossID));
                    AddUser.AddNewUser(userModel);   
                }
           }

        }

        private void cbxBoss_Checked(object sender, RoutedEventArgs e)
        {
            cbChef.IsEnabled = false;
            cbChef.SelectedItem = null;
            
            
        }

        private void cbxBoss_Unchecked(object sender, RoutedEventArgs e)
        {
            cbChef.IsEnabled = true;
        }
    }
}
