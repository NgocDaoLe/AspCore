using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using shophoatuoi.Models;

namespace shophoatuoi.Controllers
{
    public class HinhthucsController : Controller
    {
        private readonly acomptec_shophoaContext _context = new acomptec_shophoaContext();

    

        // GET: Hinhthucs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Hinhthuc.ToListAsync());
        }

        // GET: Hinhthucs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hinhthuc = await _context.Hinhthuc
                .FirstOrDefaultAsync(m => m.HtMa == id);
            if (hinhthuc == null)
            {
                return NotFound();
            }

            return View(hinhthuc);
        }

        // GET: Hinhthucs/Create
        public IActionResult Create()
        {
            int MIN = 0001;
            int MAX = 9999;
            Random RD = new Random();
            Hinhthuc obj = new Hinhthuc();
            obj.HtMa = RD.Next(MIN, MAX).ToString();
            return View(obj);
        }

        // POST: Hinhthucs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HtMa,HtTen")] Hinhthuc hinhthuc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hinhthuc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hinhthuc);
        }

        // GET: Hinhthucs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hinhthuc = await _context.Hinhthuc.FindAsync(id);
            if (hinhthuc == null)
            {
                return NotFound();
            }
            return View(hinhthuc);
        }

        // POST: Hinhthucs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("HtMa,HtTen")] Hinhthuc hinhthuc)
        {
            if (id != hinhthuc.HtMa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hinhthuc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HinhthucExists(hinhthuc.HtMa))
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
            return View(hinhthuc);
        }

        // GET: Hinhthucs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hinhthuc = await _context.Hinhthuc
                .FirstOrDefaultAsync(m => m.HtMa == id);
            if (hinhthuc == null)
            {
                return NotFound();
            }

            return View(hinhthuc);
        }

        // POST: Hinhthucs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var hinhthuc = await _context.Hinhthuc.FindAsync(id);
            _context.Hinhthuc.Remove(hinhthuc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HinhthucExists(string id)
        {
            return _context.Hinhthuc.Any(e => e.HtMa == id);
        }
    }
}
