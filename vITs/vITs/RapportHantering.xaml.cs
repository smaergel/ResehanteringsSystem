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

namespace vITs
{
    /// <summary>
    /// Interaction logic for RapportHantering.xaml
    /// </summary>
    public partial class RapportHantering : Window
    {
        public RapportHantering()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            if ((User)Application.Current.Properties["currentUser"] != null)
            {
                User id = (User)Application.Current.Properties["currentUser"];
                lblloggedin.Content = id.lastname.ToString();
            }
            else
            {
                lblloggedin.Content = "Ej inloggad";
            }
        }
        
    }
}
