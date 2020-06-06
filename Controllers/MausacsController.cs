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
    public class MausacsController : Controller
    {
        private readonly acomptec_shophoaContext _context = new acomptec_shophoaContext();

        // GET: Mausacs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Mausac.ToListAsync());
        }

        // GET: Mausacs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mausac = await _context.Mausac
                .FirstOrDefaultAsync(m => m.MsMa == id);
            if (mausac == null)
            {
                return NotFound();
            }

            return View(mausac);
        }

        // GET: Mausacs/Create
        public IActionResult Create()
        {
            int MIN = 0001;
            int MAX = 9999;
            Random RD = new Random();
            Mausac obj = new Mausac();
            obj.MsMa = RD.Next(MIN, MAX).ToString();
            return View(obj);
        }

        // POST: Mausacs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MsMa,MsTen")] Mausac mausac)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mausac);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mausac);
        }

        // GET: Mausacs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mausac = await _context.Mausac.FindAsync(id);
            if (mausac == null)
            {
                return NotFound();
            }
            return View(mausac);
        }

        // POST: Mausacs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MsMa,MsTen")] Mausac mausac)
        {
            if (id != mausac.MsMa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mausac);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MausacExists(mausac.MsMa))
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
            return View(mausac);
        }

        // GET: Mausacs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mausac = await _context.Mausac
                .FirstOrDefaultAsync(m => m.MsMa == id);
            if (mausac == null)
            {
                return NotFound();
            }

            return View(mausac);
        }

        // POST: Mausacs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var mausac = await _context.Mausac.FindAsync(id);
            _context.Mausac.Remove(mausac);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MausacExists(string id)
        {
            return _context.Mausac.Any(e => e.MsMa == id);
        }
    }
}
