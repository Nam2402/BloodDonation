using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonation.Model
{
    public class BloodType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BloodGroupId { get; set; }
    }
}
