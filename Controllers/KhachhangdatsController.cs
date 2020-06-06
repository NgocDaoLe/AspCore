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
    public class KhachhangdatsController : Controller
    {
        private readonly acomptec_shophoaContext _context = new acomptec_shophoaContext();

        // GET: Khachhangdats
        public async Task<IActionResult> Index()
        {
            return View(await _context.Khachhangdat.ToListAsync());
        }

        // GET: Khachhangdats/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachhangdat = await _context.Khachhangdat
                .FirstOrDefaultAsync(m => m.KhMa == id);
            if (khachhangdat == null)
            {
                return NotFound();
            }

            return View(khachhangdat);
        }

        // GET: Khachhangdats/Create
        public IActionResult Create()
        {
            int MIN = 0001;
            int MAX = 9999;
            Random RD = new Random();
            Khachhangdat obj = new Khachhangdat();
            obj.KhMa = RD.Next(MIN, MAX).ToString();
            return View(obj);
        }

        // POST: Khachhangdats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("KhMa,KhTen,KhSdt,KhEmail,KhDiachi,KhUsername,KhPassword")] Khachhangdat khachhangdat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(khachhangdat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(khachhangdat);
        }

        // GET: Khachhangdats/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachhangdat = await _context.Khachhangdat.FindAsync(id);
            if (khachhangdat == null)
            {
                return NotFound();
            }
            return View(khachhangdat);
        }

        // POST: Khachhangdats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("KhMa,KhTen,KhSdt,KhEmail,KhDiachi,KhUsername,KhPassword")] Khachhangdat khachhangdat)
        {
            if (id != khachhangdat.KhMa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(khachhangdat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KhachhangdatExists(khachhangdat.KhMa))
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
            return View(khachhangdat);
        }

        // GET: Khachhangdats/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachhangdat = await _context.Khachhangdat
                .FirstOrDefaultAsync(m => m.KhMa == id);
            if (khachhangdat == null)
            {
                return NotFound();
            }

            return View(khachhangdat);
        }

        // POST: Khachhangdats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var khachhangdat = await _context.Khachhangdat.FindAsync(id);
            _context.Khachhangdat.Remove(khachhangdat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KhachhangdatExists(string id)
        {
            return _context.Khachhangdat.Any(e => e.KhMa == id);
        }
    }
}
