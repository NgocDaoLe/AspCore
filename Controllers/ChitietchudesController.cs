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
    public class ChitietchudesController : Controller
    {
  private readonly acomptec_shophoaContext _context = new acomptec_shophoaContext();

        

        // GET: Chitietchudes
        public async Task<IActionResult> Index()
        {
            var acomptec_shophoaContext = _context.Chitietchude.Include(c => c.CdMaNavigation).Include(c => c.SpMaNavigation);
            return View(await acomptec_shophoaContext.ToListAsync());
        }

        // GET: Chitietchudes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitietchude = await _context.Chitietchude
                .Include(c => c.CdMaNavigation)
                .Include(c => c.SpMaNavigation)
                .FirstOrDefaultAsync(m => m.CtcdMa == id);
            if (chitietchude == null)
            {
                return NotFound();
            }

            return View(chitietchude);
        }

        // GET: Chitietchudes/Create
        public IActionResult Create()
        {
             int MIN = 0001;
            int MAX = 9999;
            Random RD = new Random();
            Chitietchude obj = new Chitietchude();
            obj.CtcdMa = RD.Next(MIN, MAX).ToString();
            ViewData["CdMa"] = new SelectList(_context.Chude, "CdMa", "CdMa");
            ViewData["SpMa"] = new SelectList(_context.Sanpham, "SpMa", "SpMa");
            return View(obj);
        }

        // POST: Chitietchudes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CtcdMa,CdMa,SpMa")] Chitietchude chitietchude)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chitietchude);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CdMa"] = new SelectList(_context.Chude, "CdMa", "CdMa", chitietchude.CdMa);
            ViewData["SpMa"] = new SelectList(_context.Sanpham, "SpMa", "SpMa", chitietchude.SpMa);
            return View(chitietchude);
        }

        // GET: Chitietchudes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitietchude = await _context.Chitietchude.FindAsync(id);
            if (chitietchude == null)
            {
                return NotFound();
            }
            ViewData["CdMa"] = new SelectList(_context.Chude, "CdMa", "CdMa", chitietchude.CdMa);
            ViewData["SpMa"] = new SelectList(_context.Sanpham, "SpMa", "SpMa", chitietchude.SpMa);
            return View(chitietchude);
        }

        // POST: Chitietchudes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CtcdMa,CdMa,SpMa")] Chitietchude chitietchude)
        {
            if (id != chitietchude.CtcdMa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chitietchude);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChitietchudeExists(chitietchude.CtcdMa))
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
            ViewData["CdMa"] = new SelectList(_context.Chude, "CdMa", "CdMa", chitietchude.CdMa);
            ViewData["SpMa"] = new SelectList(_context.Sanpham, "SpMa", "SpMa", chitietchude.SpMa);
            return View(chitietchude);
        }

        // GET: Chitietchudes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitietchude = await _context.Chitietchude
                .Include(c => c.CdMaNavigation)
                .Include(c => c.SpMaNavigation)
                .FirstOrDefaultAsync(m => m.CtcdMa == id);
            if (chitietchude == null)
            {
                return NotFound();
            }

            return View(chitietchude);
        }

        // POST: Chitietchudes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var chitietchude = await _context.Chitietchude.FindAsync(id);
            _context.Chitietchude.Remove(chitietchude);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChitietchudeExists(string id)
        {
            return _context.Chitietchude.Any(e => e.CtcdMa == id);
        }
    }
}
