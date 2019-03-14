using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonation.Model
{
    public class Register
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int NumberBloodDonation { get; set; }
        public DateTime TimeOld { get; set; }
        public DateTime TimeNew { get; set; }
        public int BloodTypeId { get; set; }
        public int EventId { get; set; }
    }
}
