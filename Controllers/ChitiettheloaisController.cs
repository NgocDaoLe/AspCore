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
    public class ChitiettheloaisController : Controller
    {
           private readonly acomptec_shophoaContext _context = new acomptec_shophoaContext();


        // GET: Chitiettheloais
        public async Task<IActionResult> Index()
        {
            var acomptec_shophoaContext = _context.Chitiettheloai.Include(c => c.SpMaNavigation).Include(c => c.TlMaNavigation);
            return View(await acomptec_shophoaContext.ToListAsync());
        }

        // GET: Chitiettheloais/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitiettheloai = await _context.Chitiettheloai
                .Include(c => c.SpMaNavigation)
                .Include(c => c.TlMaNavigation)
                .FirstOrDefaultAsync(m => m.CttlMa == id);
            if (chitiettheloai == null)
            {
                return NotFound();
            }

            return View(chitiettheloai);
        }

        // GET: Chitiettheloais/Create
        public IActionResult Create()
        {
            int MIN = 0001;
            int MAX = 9999;
            Random RD = new Random();
            Chitiettheloai obj = new Chitiettheloai();
            obj.CttlMa = RD.Next(MIN, MAX).ToString();
            ViewData["SpMa"] = new SelectList(_context.Sanpham, "SpMa", "SpMa");
            ViewData["TlMa"] = new SelectList(_context.Theloai, "TlMa", "TlMa");
            return View(obj);
        }

        // POST: Chitiettheloais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CttlMa,TlMa,SpMa")] Chitiettheloai chitiettheloai)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chitiettheloai);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SpMa"] = new SelectList(_context.Sanpham, "SpMa", "SpMa", chitiettheloai.SpMa);
            ViewData["TlMa"] = new SelectList(_context.Theloai, "TlMa", "TlMa", chitiettheloai.TlMa);
            return View(chitiettheloai);
        }

        // GET: Chitiettheloais/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitiettheloai = await _context.Chitiettheloai.FindAsync(id);
            if (chitiettheloai == null)
            {
                return NotFound();
            }
            ViewData["SpMa"] = new SelectList(_context.Sanpham, "SpMa", "SpMa", chitiettheloai.SpMa);
            ViewData["TlMa"] = new SelectList(_context.Theloai, "TlMa", "TlMa", chitiettheloai.TlMa);
            return View(chitiettheloai);
        }

        // POST: Chitiettheloais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CttlMa,TlMa,SpMa")] Chitiettheloai chitiettheloai)
        {
            if (id != chitiettheloai.CttlMa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chitiettheloai);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChitiettheloaiExists(chitiettheloai.CttlMa))
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
            ViewData["SpMa"] = new SelectList(_context.Sanpham, "SpMa", "SpMa", chitiettheloai.SpMa);
            ViewData["TlMa"] = new SelectList(_context.Theloai, "TlMa", "TlMa", chitiettheloai.TlMa);
            return View(chitiettheloai);
        }

        // GET: Chitiettheloais/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitiettheloai = await _context.Chitiettheloai
                .Include(c => c.SpMaNavigation)
                .Include(c => c.TlMaNavigation)
                .FirstOrDefaultAsync(m => m.CttlMa == id);
            if (chitiettheloai == null)
            {
                return NotFound();
            }

            return View(chitiettheloai);
        }

        // POST: Chitiettheloais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var chitiettheloai = await _context.Chitiettheloai.FindAsync(id);
            _context.Chitiettheloai.Remove(chitiettheloai);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChitiettheloaiExists(string id)
        {
            return _context.Chitiettheloai.Any(e => e.CttlMa == id);
        }
    }
}
