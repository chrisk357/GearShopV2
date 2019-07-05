﻿using System;
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
    public class HelmetsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HelmetsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Helmets
        public async Task<IActionResult> Index()
        {
            return View(await _context.Helmet.ToListAsync());
        }

        // GET: Helmets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var helmet = await _context.Helmet
                .FirstOrDefaultAsync(m => m.Id == id);
            if (helmet == null)
            {
                return NotFound();
            }

            return View(helmet);
        }

        // GET: Helmets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Helmets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,HBrand,HModel,HColor,HSize,HPrice,HSalePrice,HQtyOnHand,HImageUrl")] Helmet helmet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(helmet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(helmet);
        }

        // GET: Helmets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var helmet = await _context.Helmet.FindAsync(id);
            if (helmet == null)
            {
                return NotFound();
            }
            return View(helmet);
        }

        // POST: Helmets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,HBrand,HModel,HColor,HSize,HPrice,HSalePrice,HQtyOnHand,HImageUrl")] Helmet helmet)
        {
            if (id != helmet.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(helmet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HelmetExists(helmet.Id))
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
            return View(helmet);
        }

        // GET: Helmets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var helmet = await _context.Helmet
                .FirstOrDefaultAsync(m => m.Id == id);
            if (helmet == null)
            {
                return NotFound();
            }

            return View(helmet);
        }

        // POST: Helmets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var helmet = await _context.Helmet.FindAsync(id);
            _context.Helmet.Remove(helmet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HelmetExists(int id)
        {
            return _context.Helmet.Any(e => e.Id == id);
        }
    }
}
