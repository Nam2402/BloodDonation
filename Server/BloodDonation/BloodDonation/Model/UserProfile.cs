using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonation.Model
{
    public class UserProfile
    {
        public int UserId { get; set; }
        public string Fullname { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public Boolean Gender { get; set; }
        public DateTime DayOfBirth { get; set; }
        public string Avatar { get; set; }

    }
}
