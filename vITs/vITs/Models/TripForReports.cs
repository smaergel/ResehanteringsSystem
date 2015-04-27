using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vITs.Models
{
    public class TripForReports
    {
        public int id { get; set; }
        public string consultant { get; set; }
        public string destination { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
    }
}
