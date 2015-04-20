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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DAL.Repositories.UserRepository;
using vITs.Logic;

namespace vITs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RapportHantering cr = new RapportHantering();
            cr.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var userinput = tbxUser.Text;
            var passwordinput = pbxPassword.Password;
            
            if(userinput.Trim() == "" || passwordinput.Trim() == "")
            {
                MessageBox.Show("Fyll i alla fälten");
            }
            else
            {
                int value;
                if (int.TryParse(userinput, out value))
                {
                    var user = HandleItems.GetUser(value);
                    if (user.userID.Equals(value) && user.password.Equals(passwordinput))
                    {
<<<<<<< HEAD
=======
<<<<<<< HEAD
                        Application.Current.Properties["currentUser"] = UserHandling.GetUser(value);
=======
                        Application.Current.Properties["currentUser"] = user;
>>>>>>> origin/master
>>>>>>> parent of 5d45d47... Revert "Merge remote-tracking branch 'origin/master'"
                        var rapport = new Settings();
                        rapport.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Inlogg eller lösenord fel");
                    }
                }
                else 
                {
                    MessageBox.Show("Fyll i alla fälten");
                }
            }
            
        }
    }
}
