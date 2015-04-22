using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

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

        public static bool CheckIf3Empty(TextBox box1, TextBox box2, TextBox box3)
        {
            var text1 = box1.Text;
            var text2 = box2.Text;
            var text3 = box3.Text;

            if (text1 == "" || text2 == "" || text3 == "")
            {
                MessageBox.Show("Ett eller flera textfält är tomma");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool CheckIf2Empty(TextBox box1, TextBox box2)
        {
            var text1 = box1.Text;
            var text2 = box2.Text;
        
            if (text1 == "" || text2 == "")
            {
                MessageBox.Show("Ett eller flera textfält är tomma");
                return false;
            }
            else
            {
                return true;
            }
        }
        
    }
}
