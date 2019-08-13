using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace GearShopV2.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private UserManager<IdentityUser> _userManager;
        public AdminController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UserManagement()
        {
            var users = _userManager.Users;
            return View(users);
        }
        public IActionResult AddUser()
        {
            return View();
        }
       
    }
}