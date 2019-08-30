using GearShopV2.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using GearShopV2.Models;
using GearShopV2.Data;
using Microsoft.EntityFrameworkCore;

namespace GearShopV2.Controllers { 
//{[Authorize(Roles = "Admin")]

    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        //private readonly SignInManager<ApplicationUser> _signInManager;


        public AdminController(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> HelmetAdmin()
        {
/*            IQueryable<string> sizeQuery = from h in _context.Helmet
                                           orderby h.SizeCat
                                           select h.SizeCat;*/


            var helmets = from h in _context.Helmet
                          select h;
            


                        var gearSizeVM = new GearSizeViewModel
                        {
                            Helmets = await helmets.ToListAsync()
                        };

            return View(gearSizeVM);
        }

        public async Task<IActionResult> JerseyAdmin()
        {
            var jerseys = from j in _context.Jersey
                          select j;
            var gearSizeVM = new GearSizeViewModel
            {
                Jerseys = await jerseys.ToListAsync()
            };
            return View(gearSizeVM);

        }

        public async Task<IActionResult> PantAdmin()
        {
            var pants = from p in _context.Pant
                        select p;
            var gearSizeVM = new GearSizeViewModel
            {
                Pants = await pants.ToListAsync()
            };
            return View(gearSizeVM);
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

        [HttpPost]
        public async Task<IActionResult> AddUser(AddUserViewModel addUserViewModel)
        {
            if (!ModelState.IsValid) return View(addUserViewModel);

            var user = new ApplicationUser()
            {
                UserName = addUserViewModel.UserName,
                Email = addUserViewModel.Email,
                Birthdate = addUserViewModel.Birthdate,
                City = addUserViewModel.City,
                State = addUserViewModel.State
                
            };

            IdentityResult result = await _userManager.CreateAsync(user, addUserViewModel.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("UserManagement", _userManager.Users);
            }
            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
            return View(addUserViewModel);
        }



        [HttpPost]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user != null)
            {
                var result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                    return RedirectToAction("UserManagement");
                else
                    ModelState.AddModelError("", "Something went wrong while deleting this user.");
            }
            else
            {
                ModelState.AddModelError("", "This user can't be found");
            }
            return View("UserManagement", _userManager.Users);
        }

        public async Task<IActionResult> EditUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
                return RedirectToAction("UserManagement", _userManager.Users);

            var claims = await _userManager.GetClaimsAsync(user);
            var vm = new EditUserViewModel()
            {
                Id = user.Id,
                Email = user.Email,
                UserName = user.UserName,
                Birthdate = user.Birthdate,
                City = user.City,
                State = user.State,
                
                UserClaims = claims.Select(c => c.Value)
            .ToList()
            };

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> EditUser(EditUserViewModel editUserViewModel)
        {
            var user = await _userManager.FindByIdAsync(editUserViewModel.Id);

            if (user != null)
            {
                user.Email = editUserViewModel.Email;
                user.UserName = editUserViewModel.UserName;
                user.Birthdate = editUserViewModel.Birthdate;
                user.City = editUserViewModel.City;
                user.State = editUserViewModel.State;


                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                    return RedirectToAction("UserManagement", _userManager.Users);

                ModelState.AddModelError("", "User not updated, something went wrong.");

                return View(editUserViewModel);
            }

            return RedirectToAction("UserManagement", _userManager.Users);
        }


    }
}