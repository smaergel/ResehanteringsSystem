using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vITs.Models
{
    public class VacationModel
    {
        public int vacationID { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public int tripID { get; set; }
    }
}
