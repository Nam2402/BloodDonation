using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonation.Model
{
    public class Pictures
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int PostId { get; set; }
    }
}
