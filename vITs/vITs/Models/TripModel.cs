using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vITs.Models
{
    public class TripModel
    {
        public int TripId { get; set; }
        public int Origin { get; set; }
        public int Destination { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int? Prepayment { get; set; }
        public string Note { get; set; }
        public int User { get; set; }
        public int BossId { get; set; }
        public int? Status { get; set; }
    }
}
