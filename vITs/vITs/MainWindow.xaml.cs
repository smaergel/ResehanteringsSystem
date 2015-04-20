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
            CenterWindowOnScreen();
            tbxUser.Focus();
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
                        Application.Current.Properties["currentUser"] = user;
                        Application.Current.Properties["currentUser"] = UserHandling.GetUser(value);
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

        private void CenterWindowOnScreen()
        {
            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;
            this.Left = (screenWidth / 2) - (windowWidth / 2);
            this.Top = (screenHeight / 2) - (windowHeight / 2);
        }

    }
}
