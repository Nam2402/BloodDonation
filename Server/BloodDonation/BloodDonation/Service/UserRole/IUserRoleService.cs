using BloodDonation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BloodDonation.Service.UserRole
{
    public interface IUserRoleService
    {
        List<UserRoles> GetAllUserRole();
    }
}
