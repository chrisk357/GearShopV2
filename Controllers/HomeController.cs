using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GearShopV2.Models;
using GearShopV2.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace GearShopV2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }
        //push update
        public async Task<IActionResult> Contacts()
        {
                     

            var contacts = from c in _context.ContactUs
                           select c;


            var contactUsVM = new ContactUsViewModel
            {
                Contacts = await contacts.ToListAsync()
            };

            return View(contactUsVM);
        }


        public IActionResult OnGetPartial() =>
            new PartialViewResult
            {
                ViewName = "_Contacts",
                //ViewData = Contacts,
            };



        [HttpGet]
        public IActionResult ContactUs()
        {
            return View();
        }
        [Authorize]
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> ContactUs([Bind("Id, ContactName, ContactEmail, ContactMessage, Posted")] ContactUs contact)
        {
            
            if (ModelState.IsValid)
            {
                contact.Posted = DateTime.Now;
              //  contact.Posted.Equals(DateTime.Now);
                _context.Add(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contact);
        }


        private bool ContactExists(int id)
        {
            return _context.ContactUs.Any(e => e.Id == id);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
