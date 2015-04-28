using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vITs.Models
{
    public class FullTrip
    {
        public TripModel myTrip { get; set; }
        public List<VerificationModel> myVerifications { get; set; }
        public List<VacationModel> myVacation { get; set; }

    }
}
