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
    public class TheloaisController : Controller
    {
       private readonly acomptec_shophoaContext _context = new acomptec_shophoaContext();

        // GET: Theloais
        public async Task<IActionResult> Index()
        {
            return View(await _context.Theloai.ToListAsync());
        }

        // GET: Theloais/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var theloai = await _context.Theloai
                .FirstOrDefaultAsync(m => m.TlMa == id);
            if (theloai == null)
            {
                return NotFound();
            }

            return View(theloai);
        }

        // GET: Theloais/Create
        public IActionResult Create()
        {
            int MIN = 0001;
            int MAX = 9999;
            Random RD = new Random();
            Theloai obj = new Theloai();
            obj.TlMa = RD.Next(MIN, MAX).ToString();
            return View(obj);
        }

        // POST: Theloais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TlMa,TlTen")] Theloai theloai)
        {
            if (ModelState.IsValid)
            {
                _context.Add(theloai);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(theloai);
        }

        // GET: Theloais/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var theloai = await _context.Theloai.FindAsync(id);
            if (theloai == null)
            {
                return NotFound();
            }
            return View(theloai);
        }

        // POST: Theloais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("TlMa,TlTen")] Theloai theloai)
        {
            if (id != theloai.TlMa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(theloai);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TheloaiExists(theloai.TlMa))
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
            return View(theloai);
        }

        // GET: Theloais/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var theloai = await _context.Theloai
                .FirstOrDefaultAsync(m => m.TlMa == id);
            if (theloai == null)
            {
                return NotFound();
            }

            return View(theloai);
        }

        // POST: Theloais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var theloai = await _context.Theloai.FindAsync(id);
            _context.Theloai.Remove(theloai);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TheloaiExists(string id)
        {
            return _context.Theloai.Any(e => e.TlMa == id);
        }
    }
}
