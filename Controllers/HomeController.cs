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
using Microsoft.AspNetCore.Identity;
using GearShopV2.ViewModels;

namespace GearShopV2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        public IActionResult Index()
        {
            return View();
        }
        //push update
        public async Task<IActionResult> Contacts()
        {
                     

            var contacts = from c in _context.ContactUs
                           orderby c.Posted descending
                           select c;


            var contactUsVM = new ContactUsViewModel
            {
                Contacts = await contacts.ToListAsync()
            };

            return View(contactUsVM);
        }





/*        public IActionResult OnGetPartial() =>
            new PartialViewResult
            {
                ViewName = "_Contacts",
                //ViewData = Contacts,
            };*/



        [HttpGet]
        public IActionResult ContactUs()
        {
            return View();
        }

        // POST: Contacts
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> ContactUs([Bind("Id, ContactName, ContactEmail, ContactMessage, Posted")] ContactUs contact)
        {
            
            if (ModelState.IsValid)
            {
                contact.Posted = DateTime.Now;
              //  contact.Posted.Equals(DateTime.Now);
                _context.Add(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Contacts));
            }
            return View(contact);
        }

        // GET: Contacts/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var contact = await _context.ContactUs
                .FirstOrDefaultAsync(c => c.Id == id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }

        // POST: Contacts/Delete/5
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contact = await _context.ContactUs.FindAsync(id);
            _context.ContactUs.Remove(contact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Contacts));
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
