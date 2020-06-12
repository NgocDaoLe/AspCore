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
    public class NhansusController : Controller
    {
        private readonly acomptec_shophoaContext _context = new acomptec_shophoaContext();

        

        // GET: Nhansus
        public async Task<IActionResult> Index()
        {
            
            return View(await _context.Nhansu.ToListAsync());
        }

        // GET: Nhansus/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhansu = await _context.Nhansu
                .Include(n => n.Chucvu)
                .FirstOrDefaultAsync(m => m.NsMa == id);
            if (nhansu == null)
            {
                return NotFound();
            }

            return View(nhansu);
        }

        // GET: Nhansus/Create
        public IActionResult Create()
        {

            ViewData["CvMa"] = new SelectList(_context.Chucvu, "CvMa", "CvMa");
            int MIN = 1000;
            int MAX = 9999;
            Random RD = new Random();
            Nhansu obj = new Nhansu();
            obj.NsMa = RD.Next(MIN, MAX).ToString();
            return View(obj);
        }

        // POST: Nhansus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NsMa,CvMa,NsHoten,NsNamsinh,NsCmnd,NsSdt,NsDiachi,NsUsername,NsPassword")] Nhansu nhansu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nhansu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CvMa"] = new SelectList(_context.Chucvu, "CvMa", "CvMa", nhansu.CvMa);
            return View(nhansu);
        }

        // GET: Nhansus/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhansu = await _context.Nhansu.FindAsync(id);
            if (nhansu == null)
            {
                return NotFound();
            }
            ViewData["CvMa"] = new SelectList(_context.Chucvu, "CvMa", "CvMa", nhansu.CvMa);
            return View(nhansu);
        }

        // POST: Nhansus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NsMa,CvMa,NsHoten,NsNamsinh,NsCmnd,NsSdt,NsDiachi,NsUsername,NsPassword")] Nhansu nhansu)
        {
            if (id != nhansu.NsMa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nhansu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NhansuExists(nhansu.NsMa))
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
            ViewData["CvMa"] = new SelectList(_context.Chucvu, "CvMa", "CvMa", nhansu.CvMa);
            return View(nhansu);
        }

        // GET: Nhansus/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhansu = await _context.Nhansu
                .Include(n => n.Chucvu)
                .FirstOrDefaultAsync(m => m.NsMa == id);
            if (nhansu == null)
            {
                return NotFound();
            }

            return View(nhansu);
        }

        // POST: Nhansus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nhansu = await _context.Nhansu.FindAsync(id);
            _context.Nhansu.Remove(nhansu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NhansuExists(string id)
        {
            return _context.Nhansu.Any(e => e.NsMa == id);
        }
    }
}
