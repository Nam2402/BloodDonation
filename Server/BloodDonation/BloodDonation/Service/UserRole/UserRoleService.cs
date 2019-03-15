using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloodDonation.Database;
using BloodDonation.Model;

namespace BloodDonation.Service.UserRole
{
    public class UserRoleService : IUserRoleService
    {
        private DatabaseContext _context;

        public UserRoleService(DatabaseContext context)
        {
            _context = context;
        }

        public List<UserRoles> GetAllUserRole()
        {
            List<UserRoles> userRoles = _context.UserRole.Where(n => !n.DeleteFlag).ToList();
            return userRoles;

        }
    }
}
