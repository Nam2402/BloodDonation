using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonation.Model
{
    public class Notification
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string Content { get; set; }
        public int RequestId { get; set; }
    }
}
