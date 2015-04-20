using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vITs.Models
{
    class TripModel
    {
        public int Origin { get; set; }
        public int Destination { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int Prepayment { get; set; }
        public string Note { get; set; }
        public int User { get; set; }
        public int Boss { get; set; }
        public bool Status { get; set; }
    }
}
