using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vITs.Models
{
    public class TripModel
    {
        public int origin { get; set; }
        public int destination { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public int prepayment { get; set; }
        public string note { get; set; }
        public int user { get; set; }
<<<<<<< HEAD
=======
        public int boss { get; set; }
        public bool status { get; set; }
>>>>>>> origin/testmerge
    }
}
