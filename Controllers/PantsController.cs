using GearShopV2.Data;
using GearShopV2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GearShopV2.Controllers
{
    public class PantsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PantsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Pants
        public async Task<IActionResult> Index(string sizeCategory, string searchString)
        {
            IQueryable<string> sizeQuery = from p in _context.Pant
                                           orderby p.SizeCat
                                           select p.SizeCat;

            var pants = from p in _context.Pant
                        select p;

            if (!string.IsNullOrEmpty(searchString))
            {
                pants = pants.Where(s => s.PBrand.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(sizeCategory))
            {
                pants = pants.Where(X => X.SizeCat == sizeCategory);
            }

            var gearSizeVM = new GearSizeViewModel
            {
                SizeCats = new SelectList(await sizeQuery.Distinct().ToListAsync()),
                Pants = await pants.ToListAsync()
            };

            return View(gearSizeVM);
        }

        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }


        // GET: Pants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pant = await _context.Pant
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pant == null)
            {
                return NotFound();
            }

            return View(pant);
        }

        // GET: Pants/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PBrand,PModel,PColor,PSize,PPrice,PSalePrice,PQtyOnHand,PImageUrl,PSizeCat")] Pant pant)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pant);
        }

        // GET: Pants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pant = await _context.Pant.FindAsync(id);
            if (pant == null)
            {
                return NotFound();
            }
            return View(pant);
        }

        // POST: Pants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PBrand,PModel,PColor,PSize,PPrice,PSalePrice,PQtyOnHand,PImageUrl,PSizeCat")] Pant pant)
        {
            if (id != pant.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PantExists(pant.Id))
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
            return View(pant);
        }

        // GET: Pants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pant = await _context.Pant
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pant == null)
            {
                return NotFound();
            }

            return View(pant);
        }

        // POST: Pants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pant = await _context.Pant.FindAsync(id);
            _context.Pant.Remove(pant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PantExists(int id)
        {
            return _context.Pant.Any(e => e.Id == id);
        }
    }
}
