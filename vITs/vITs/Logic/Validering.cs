using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace vITs.Logic
{
    class Validering
    {

        public static bool CheckPrepaySum(int sum)
        {
            if (sum < 0)
            {
                MessageBox.Show("För in ett positivt tal i fältet eller lämna tomt!");
                return false;

            }
            return true;
        }
        
    }
}
