using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vITs.Models
{
    public class UserModel
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public int boss { get; set; }

        public UserModel(string fn,string ln, string pw, string e, string phon, int bs)
        {
            firstname = fn;
            lastname = ln;
            password = pw;
            email = e;
            phone = phon;
            boss = bs;
        }
    }
}
