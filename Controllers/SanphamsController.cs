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
    public class SanphamsController : Controller
    {
       private readonly acomptec_shophoaContext _context = new acomptec_shophoaContext();


        // GET: Sanphams
        public async Task<IActionResult> Index()
        {
            var acomptec_shophoaContext = _context.Sanpham.Include(s => s.Hinhanh);
            return View(await acomptec_shophoaContext.ToListAsync());
        }

        // GET: Sanphams/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanpham = await _context.Sanpham
                .Include(s => s.Hinhanh)
                .FirstOrDefaultAsync(m => m.SpMa == id);
            if (sanpham == null)
            {
                return NotFound();
            }

            return View(sanpham);
        }

        // GET: Sanphams/Create
        public IActionResult Create()
        {
            int MIN = 0001;
            int MAX = 9999;
            Random RD = new Random();
            Sanpham obj = new Sanpham();
            obj.SpMa = RD.Next(MIN, MAX).ToString();
            ViewData["HaMa"] = new SelectList(_context.Hinhanh, "HaMa", "HaMa");
            return View(obj);
        }

        // POST: Sanphams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SpMa,SpTen,SpGia,SpMotachitiet,SpGioithieu,HaMa")] Sanpham sanpham)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sanpham);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HaMa"] = new SelectList(_context.Hinhanh, "HaMa", "HaMa", sanpham.HaMa);
            return View(sanpham);
        }

        // GET: Sanphams/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanpham = await _context.Sanpham.FindAsync(id);
            if (sanpham == null)
            {
                return NotFound();
            }
            ViewData["HaMa"] = new SelectList(_context.Hinhanh, "HaMa", "HaMa", sanpham.HaMa);
            return View(sanpham);
        }

        // POST: Sanphams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("SpMa,SpTen,SpGia,SpMotachitiet,SpGioithieu,HaMa")] Sanpham sanpham)
        {
            if (id != sanpham.SpMa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sanpham);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SanphamExists(sanpham.SpMa))
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
            ViewData["HaMa"] = new SelectList(_context.Hinhanh, "HaMa", "HaMa", sanpham.HaMa);
            return View(sanpham);
        }

        // GET: Sanphams/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanpham = await _context.Sanpham
                .Include(s => s.Hinhanh)
                .FirstOrDefaultAsync(m => m.SpMa == id);
            if (sanpham == null)
            {
                return NotFound();
            }

            return View(sanpham);
        }

        // POST: Sanphams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var sanpham = await _context.Sanpham.FindAsync(id);
            _context.Sanpham.Remove(sanpham);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SanphamExists(string id)
        {
            return _context.Sanpham.Any(e => e.SpMa == id);
        }
    }
}
