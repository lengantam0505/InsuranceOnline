using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InsuranceOnline.Models;

namespace InsuranceOnline.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminstratorsController : Controller
    {
        private readonly InsuranceDBContext _context;

        public AdminstratorsController(InsuranceDBContext context)
        {
            _context = context;
        }

        // GET: Admin/Adminstrators
        public async Task<IActionResult> Index()
        {
            return View(await _context.Adminstrators.ToListAsync());
        }

        // GET: Admin/Adminstrators/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adminstrator = await _context.Adminstrators
                .FirstOrDefaultAsync(m => m.ID == id);
            if (adminstrator == null)
            {
                return NotFound();
            }

            return View(adminstrator);
        }

        // GET: Admin/Adminstrators/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Adminstrators/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
       

        // GET: Admin/Adminstrators/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adminstrator = await _context.Adminstrators.FindAsync(id);
            if (adminstrator == null)
            {
                return NotFound();
            }
            return View(adminstrator);
        }

        // POST: Admin/Adminstrators/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Username,Password")] Adminstrator adminstrator)
        {
            if (id != adminstrator.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(adminstrator);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdminstratorExists(adminstrator.ID))
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
            return View(adminstrator);
        }

        // GET: Admin/Adminstrators/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adminstrator = await _context.Adminstrators
                .FirstOrDefaultAsync(m => m.ID == id);
            if (adminstrator == null)
            {
                return NotFound();
            }

            return View(adminstrator);
        }

        // POST: Admin/Adminstrators/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var adminstrator = await _context.Adminstrators.FindAsync(id);
            _context.Adminstrators.Remove(adminstrator);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdminstratorExists(int id)
        {
            return _context.Adminstrators.Any(e => e.ID == id);
        }
    }
}
