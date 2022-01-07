using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Test1.Models;

namespace Test1.Controllers
{
    public class CompanyNTN535Controller : Controller
    {
        private readonly KiemTraDbContext _context;

        public CompanyNTN535Controller(KiemTraDbContext context)
        {
            _context = context;
        }

        // GET: CompanyNTN535
        public async Task<IActionResult> Index()
        {
            return View(await _context.CompanyNTN535.ToListAsync());
        }

        // GET: CompanyNTN535/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyNTN535 = await _context.CompanyNTN535
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyNTN535 == null)
            {
                return NotFound();
            }

            return View(companyNTN535);
        }

        // GET: CompanyNTN535/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompanyNTN535/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyId,CompanyName")] CompanyNTN535 companyNTN535)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyNTN535);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companyNTN535);
        }

        // GET: CompanyNTN535/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyNTN535 = await _context.CompanyNTN535.FindAsync(id);
            if (companyNTN535 == null)
            {
                return NotFound();
            }
            return View(companyNTN535);
        }

        // POST: CompanyNTN535/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CompanyId,CompanyName")] CompanyNTN535 companyNTN535)
        {
            if (id != companyNTN535.CompanyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyNTN535);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyNTN535Exists(companyNTN535.CompanyId))
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
            return View(companyNTN535);
        }

        // GET: CompanyNTN535/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyNTN535 = await _context.CompanyNTN535
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyNTN535 == null)
            {
                return NotFound();
            }

            return View(companyNTN535);
        }

        // POST: CompanyNTN535/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var companyNTN535 = await _context.CompanyNTN535.FindAsync(id);
            _context.CompanyNTN535.Remove(companyNTN535);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyNTN535Exists(string id)
        {
            return _context.CompanyNTN535.Any(e => e.CompanyId == id);
        }
    }
}
