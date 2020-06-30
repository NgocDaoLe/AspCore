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
    public class BaivietsController : Controller
    {
        private readonly acomptec_shophoaContext _context = new acomptec_shophoaContext();

       

        // GET: Baiviets
        public async Task<IActionResult> Index()
        {
            return View(await _context.Baiviet.ToListAsync());
        }

        // GET: Baiviets/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var baiviet = await _context.Baiviet
                .FirstOrDefaultAsync(m => m.BvMa == id);
            if (baiviet == null)
            {
                return NotFound();
            }

            return View(baiviet);
        }

        // GET: Baiviets/Create
        public IActionResult Create()
        {
            int MIN = 0001;
            int MAX = 9999;
            Random RD = new Random();
            Baiviet obj = new Baiviet();
            obj.BvMa = RD.Next(MIN, MAX).ToString();
            return View(obj);
        }

        // POST: Baiviets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BvMa,BvTen,BvNoidung")] Baiviet baiviet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(baiviet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(baiviet);
        }

        // GET: Baiviets/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var baiviet = await _context.Baiviet.FindAsync(id);
            if (baiviet == null)
            {
                return NotFound();
            }
            return View(baiviet);
        }

        // POST: Baiviets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("BvMa,BvTen,BvNoidung")] Baiviet baiviet)
        {
            if (id != baiviet.BvMa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(baiviet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BaivietExists(baiviet.BvMa))
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
            return View(baiviet);
        }

        // GET: Baiviets/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var baiviet = await _context.Baiviet
                .FirstOrDefaultAsync(m => m.BvMa == id);
            if (baiviet == null)
            {
                return NotFound();
            }

            return View(baiviet);
        }

        // POST: Baiviets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var baiviet = await _context.Baiviet.FindAsync(id);
            _context.Baiviet.Remove(baiviet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BaivietExists(string id)
        {
            return _context.Baiviet.Any(e => e.BvMa == id);
        }
    }
}
