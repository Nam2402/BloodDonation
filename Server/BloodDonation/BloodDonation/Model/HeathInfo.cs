using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonation.Model
{
    public class HeathInfo
    {
        public int UserId { get; set; }
        public int BloodTypeId { get; set; }
        public int NumberBloodDonation { get; set; }
        public int Volumetric { get; set; }
        public DateTime TimeDonationRecent { get; set; }
    }
}
