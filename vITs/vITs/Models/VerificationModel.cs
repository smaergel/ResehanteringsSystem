using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vITs.Models
{
    public class VerificationModel
    {
        public int expenceID { get; set; }
        public double cost { get; set; }
        public string path { get; set; }
        public DateTime date { get; set; }
        public string note { get; set; }
        public int tripID { get; set; }

        
    }
}
