using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using shophoatuoi.Models;
using Microsoft.AspNetCore.Http;

namespace shophoatuoi.Controllers
{
    public class ChucvusController : Controller
    {
        private readonly acomptec_shophoaContext _context = new acomptec_shophoaContext();

        // GET: Chucvus
        public async Task<IActionResult> Index()
        {
            ViewBag.User = HttpContext.Session.GetString("User");
            return View(await _context.Chucvu.ToListAsync());
        }

        // GET: Chucvus/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chucvu = await _context.Chucvu
                .FirstOrDefaultAsync(m => m.CvMa == id);
            if (chucvu == null)
            {
                return NotFound();
            }

            return View(chucvu);
        }

        // GET: Chucvus/Create
        public IActionResult Create()
        {
            int MIN = 0001;
            int MAX = 9999;
            Random RD = new Random();
            Chucvu obj = new Chucvu();
            obj.CvMa = RD.Next(MIN, MAX).ToString();
            return View(obj);
        }

        // POST: Chucvus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CvMa,CvTen,CvMotacongviec")] Chucvu chucvu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chucvu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chucvu);
        }

        // GET: Chucvus/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chucvu = await _context.Chucvu.FindAsync(id);
            if (chucvu == null)
            {
                return NotFound();
            }
            return View(chucvu);
        }

        // POST: Chucvus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CvMa,CvTen,CvMotacongviec")] Chucvu chucvu)
        {
            if (id != chucvu.CvMa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chucvu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChucvuExists(chucvu.CvMa))
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
            return View(chucvu);
        }

        // GET: Chucvus/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chucvu = await _context.Chucvu
                .FirstOrDefaultAsync(m => m.CvMa == id);
            if (chucvu == null)
            {
                return NotFound();
            }

            return View(chucvu);
        }

        // POST: Chucvus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var chucvu = await _context.Chucvu.FindAsync(id);
            _context.Chucvu.Remove(chucvu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChucvuExists(string id)
        {
            return _context.Chucvu.Any(e => e.CvMa == id);
        }
    }
}
