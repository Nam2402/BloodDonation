using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonation.Model
{
    public class CRUDDate
    {
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool DeleteFlag { get; set; }
    }
}
