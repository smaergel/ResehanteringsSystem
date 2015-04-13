﻿using System;
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
using DAL;

namespace vITs
{
        
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public User loggedInUser;

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
                System.Windows.MessageBox.Show("Fyll i alla fälten");
            }
            else
            {
                int value;
                if (int.TryParse(userinput, out value))
                {
                    if (UserHandling.GetUser(value) != null)
                    {
<<<<<<< HEAD
                        if (UserHandling.GetUser(value).userID.Equals(value) && UserHandling.GetUser(value).password.Equals(passwordinput))
                        {
                            loggedInUser = UserHandling.GetUser(value);
                            
                            RapportHantering cr = new RapportHantering();
                            cr.Show();
                            this.Close();
                            Application.Current.Properties["currentUser"] = UserHandling.GetUser(value);
                            
                        }
                        else
                        {
                            System.Windows.MessageBox.Show("Inlogg eller lösenord fel");
                        }
=======
                        var rapport = new RapportHantering();
                        rapport.Show();
                        Close();
>>>>>>> origin/master
                    }
                    else
                    {
                        MessageBox.Show("Finns ingen anställd med det anställningsnumret.");
                    }
                }
                else 
                {
                    System.Windows.MessageBox.Show("Fyll i alla fälten");
                }
            }
            
        }
    }
}
