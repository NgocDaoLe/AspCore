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
    public class ChitietmausacsController : Controller
    {
       private readonly acomptec_shophoaContext _context = new acomptec_shophoaContext();

        

        // GET: Chitietmausacs
        public async Task<IActionResult> Index()
        {
            var acomptec_shophoaContext = _context.Chitietmausac.Include(c => c.MsMaNavigation).Include(c => c.SpMaNavigation);
            return View(await acomptec_shophoaContext.ToListAsync());
        }

        // GET: Chitietmausacs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitietmausac = await _context.Chitietmausac
                .Include(c => c.MsMaNavigation)
                .Include(c => c.SpMaNavigation)
                .FirstOrDefaultAsync(m => m.CtmsMa == id);
            if (chitietmausac == null)
            {
                return NotFound();
            }

            return View(chitietmausac);
        }

        // GET: Chitietmausacs/Create
        public IActionResult Create()
        {
            int MIN = 0001;
            int MAX = 9999;
            Random RD = new Random();
            Chitietmausac obj = new Chitietmausac();
            obj.CtmsMa = RD.Next(MIN, MAX).ToString();
            ViewData["MsMa"] = new SelectList(_context.Mausac, "MsMa", "MsMa");
            ViewData["SpMa"] = new SelectList(_context.Sanpham, "SpMa", "SpMa");
            return View(obj);
        }

        // POST: Chitietmausacs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CtmsMa,MsMa,SpMa")] Chitietmausac chitietmausac)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chitietmausac);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MsMa"] = new SelectList(_context.Mausac, "MsMa", "MsMa", chitietmausac.MsMa);
            ViewData["SpMa"] = new SelectList(_context.Sanpham, "SpMa", "SpMa", chitietmausac.SpMa);
            return View(chitietmausac);
        }

        // GET: Chitietmausacs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitietmausac = await _context.Chitietmausac.FindAsync(id);
            if (chitietmausac == null)
            {
                return NotFound();
            }
            ViewData["MsMa"] = new SelectList(_context.Mausac, "MsMa", "MsMa", chitietmausac.MsMa);
            ViewData["SpMa"] = new SelectList(_context.Sanpham, "SpMa", "SpMa", chitietmausac.SpMa);
            return View(chitietmausac);
        }

        // POST: Chitietmausacs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CtmsMa,MsMa,SpMa")] Chitietmausac chitietmausac)
        {
            if (id != chitietmausac.CtmsMa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chitietmausac);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChitietmausacExists(chitietmausac.CtmsMa))
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
            ViewData["MsMa"] = new SelectList(_context.Mausac, "MsMa", "MsMa", chitietmausac.MsMa);
            ViewData["SpMa"] = new SelectList(_context.Sanpham, "SpMa", "SpMa", chitietmausac.SpMa);
            return View(chitietmausac);
        }

        // GET: Chitietmausacs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitietmausac = await _context.Chitietmausac
                .Include(c => c.MsMaNavigation)
                .Include(c => c.SpMaNavigation)
                .FirstOrDefaultAsync(m => m.CtmsMa == id);
            if (chitietmausac == null)
            {
                return NotFound();
            }

            return View(chitietmausac);
        }

        // POST: Chitietmausacs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var chitietmausac = await _context.Chitietmausac.FindAsync(id);
            _context.Chitietmausac.Remove(chitietmausac);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChitietmausacExists(string id)
        {
            return _context.Chitietmausac.Any(e => e.CtmsMa == id);
        }
    }
}
