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
    public class ChitiethinhthucsController : Controller
    {
          private readonly acomptec_shophoaContext _context = new acomptec_shophoaContext();


        // GET: Chitiethinhthucs
        public async Task<IActionResult> Index(string id)
        {
            var acomptec_shophoaContext = _context.Chitiethinhthuc.Include(c => c.HtMaNavigation).Include(c => c.SpMaNavigation).Where(c => c.SpMa == id);
            ViewBag.SpMa = id;
            return View(await acomptec_shophoaContext.ToListAsync());
        }

        // GET: Chitiethinhthucs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitiethinhthuc = await _context.Chitiethinhthuc
                .Include(c => c.HtMaNavigation)
                .Include(c => c.SpMaNavigation)
                .FirstOrDefaultAsync(m => m.CthtMa == id);
            if (chitiethinhthuc == null)
            {
                return NotFound();
            }

            return View(chitiethinhthuc);
        }

        // GET: Chitiethinhthucs/Create
        public IActionResult Create(string id)
        {
            ViewData["HtTen"] = new SelectList(_context.Hinhthuc, "HtMa", "HtTen");
            int MIN = 0001;
            int MAX = 9999;
            Random RD = new Random();
            Chitiethinhthuc obj = new Chitiethinhthuc();
            obj.CthtMa = RD.Next(MIN, MAX).ToString();
            ViewBag.SpMa =id;
            return View(obj);
        }

        // POST: Chitiethinhthucs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CthtMa,HtMa,SpMa")] Chitiethinhthuc chitiethinhthuc)
        {
            string duongdan = "Index/" + chitiethinhthuc.HtMa; 
            if (ModelState.IsValid)
            {
                _context.Add(chitiethinhthuc);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index","chitiethinhthucs", new { @id = chitiethinhthuc.SpMa});
            }
            //ViewData["HtMa"] = new SelectList(_context.Hinhthuc, "HtMa", "HtTen", chitiethinhthuc.HtMa);
            ViewData["SpMa"] = new SelectList(_context.Sanpham, "SpMa", "SpTen", chitiethinhthuc.SpMa);
            return View(duongdan);
        }

        // GET: Chitiethinhthucs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitiethinhthuc = await _context.Chitiethinhthuc.FindAsync(id);
            if (chitiethinhthuc == null)
            {
                return NotFound();
            }
            ViewData["HtMa"] = new SelectList(_context.Hinhthuc, "HtMa", "HtMa", chitiethinhthuc.HtMa);
            //ViewData["SpMa"] = new SelectList(_context.Sanpham, "SpMa", "SpMa", chitiethinhthuc.SpMa);
            return View(chitiethinhthuc);
        }

        // POST: Chitiethinhthucs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CthtMa,HtMa,SpMa")] Chitiethinhthuc chitiethinhthuc)
        {
            if (id != chitiethinhthuc.CthtMa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chitiethinhthuc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChitiethinhthucExists(chitiethinhthuc.CthtMa))
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
            ViewData["HtMa"] = new SelectList(_context.Hinhthuc, "HtMa", "HtMa", chitiethinhthuc.HtMa);
            ViewData["SpMa"] = new SelectList(_context.Sanpham, "SpMa", "SpMa", chitiethinhthuc.SpMa);
            return View(chitiethinhthuc);
        }

        // GET: Chitiethinhthucs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitiethinhthuc = await _context.Chitiethinhthuc
                .Include(c => c.HtMaNavigation)
                .Include(c => c.SpMaNavigation)
                .FirstOrDefaultAsync(m => m.CthtMa == id);
            if (chitiethinhthuc == null)
            {
                return NotFound();
            }

            return View(chitiethinhthuc);
        }

        // POST: Chitiethinhthucs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var chitiethinhthuc = await _context.Chitiethinhthuc.FindAsync(id);
            _context.Chitiethinhthuc.Remove(chitiethinhthuc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChitiethinhthucExists(string id)
        {
            return _context.Chitiethinhthuc.Any(e => e.CthtMa == id);
        }
    }
}
