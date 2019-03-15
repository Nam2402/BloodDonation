using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonation.Model
{
    public class User:CRUDDate
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string password { get; set; }
        public int RoleId { get; set; }
    }
}
