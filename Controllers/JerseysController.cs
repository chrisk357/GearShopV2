using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GearShopV2.Data;
using GearShopV2.Models;

namespace GearShopV2.Controllers
{
    public class JerseysController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JerseysController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Jerseys
        public async Task<IActionResult> Index(string gearColor, string searchString)

        {
            //Use LINQ to get a list of all colors
            IQueryable<string> colorQuery = from j in _context.Jersey
                                            orderby j.JColor
                                            select j.JColor;

            var jerseys = from j in _context.Jersey
                          select j;

            if (!String.IsNullOrEmpty(searchString))
            {
                jerseys = jerseys.Where(s => s.JBrand.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(gearColor))
            {
                jerseys = jerseys.Where(x => x.JColor == gearColor);
            }

            return View(await jerseys.ToListAsync());
        }


        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }


        // GET: Jerseys/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jersey = await _context.Jersey
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jersey == null)
            {
                return NotFound();
            }

            return View(jersey);
        }

        // GET: Jerseys/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Jerseys/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,JBrand,JModel,JColor,JSize,JPrice,JSalePrice,JQtyOnHand,JImageUrl,JSizeCat")] Jersey jersey)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jersey);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jersey);
        }

        // GET: Jerseys/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jersey = await _context.Jersey.FindAsync(id);
            if (jersey == null)
            {
                return NotFound();
            }
            return View(jersey);
        }

        // POST: Jerseys/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,JBrand,JModel,JColor,JSize,JPrice,JSalePrice,JQtyOnHand,JImageUrl,JSizeCat")] Jersey jersey)
        {
            if (id != jersey.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jersey);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JerseyExists(jersey.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(jersey);
        }

        // GET: Jerseys/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jersey = await _context.Jersey
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jersey == null)
            {
                return NotFound();
            }

            return View(jersey);
        }

        // POST: Jerseys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jersey = await _context.Jersey.FindAsync(id);
            _context.Jersey.Remove(jersey);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JerseyExists(int id)
        {
            return _context.Jersey.Any(e => e.Id == id);
        }
    }
}
