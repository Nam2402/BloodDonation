using BloodDonation.Model;
using BloodDonation.Service.UserRole;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRoleController : Controller
    {

        private IUserRoleService _userRoleService;
        public UserRoleController(IUserRoleService userRoleService)
        {
            _userRoleService = userRoleService;
           
        }
        [HttpGet]
        public IActionResult GetAllUserRole()
        {
            List<UserRoles> UserRoles = _userRoleService.GetAllUserRole();
            return Ok(UserRoles);
        }
    }
}
