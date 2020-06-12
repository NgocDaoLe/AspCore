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
    public class ChitiethoadonsController : Controller
    {
        private readonly acomptec_shophoaContext _context;

        public ChitiethoadonsController(acomptec_shophoaContext context)
        {
            _context = context;
        }

        // GET: Chitiethoadons
        public async Task<IActionResult> Index()
        {
            var acomptec_shophoaContext = _context.Chitiethoadon.Include(c => c.HdMaNavigation).Include(c => c.KhMaNavigation).Include(c => c.SpMaNavigation);
            return View(await acomptec_shophoaContext.ToListAsync());
        }

        // GET: Chitiethoadons/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitiethoadon = await _context.Chitiethoadon
                .Include(c => c.HdMaNavigation)
                .Include(c => c.KhMaNavigation)
                .Include(c => c.SpMaNavigation)
                .FirstOrDefaultAsync(m => m.CthdMa == id);
            if (chitiethoadon == null)
            {
                return NotFound();
            }

            return View(chitiethoadon);
        }

        // GET: Chitiethoadons/Create
        public IActionResult Create()
        {
            ViewData["HdMa"] = new SelectList(_context.Hoadon, "HdMa", "HdMa");
            ViewData["KhMa"] = new SelectList(_context.Khachhangdat, "KhMa", "KhMa");
            ViewData["SpMa"] = new SelectList(_context.Sanpham, "SpMa", "SpMa");
            return View();
        }

        // POST: Chitiethoadons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CthdMa,SpMa,HdMa,KhMa,CthdSoluong,CthdTamtinh,CthdPhigiaohang,CthdThanhtien")] Chitiethoadon chitiethoadon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chitiethoadon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HdMa"] = new SelectList(_context.Hoadon, "HdMa", "HdMa", chitiethoadon.HdMa);
            ViewData["KhMa"] = new SelectList(_context.Khachhangdat, "KhMa", "KhMa", chitiethoadon.KhMa);
            ViewData["SpMa"] = new SelectList(_context.Sanpham, "SpMa", "SpMa", chitiethoadon.SpMa);
            return View(chitiethoadon);
        }

        // GET: Chitiethoadons/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitiethoadon = await _context.Chitiethoadon.FindAsync(id);
            if (chitiethoadon == null)
            {
                return NotFound();
            }
            ViewData["HdMa"] = new SelectList(_context.Hoadon, "HdMa", "HdMa", chitiethoadon.HdMa);
            ViewData["KhMa"] = new SelectList(_context.Khachhangdat, "KhMa", "KhMa", chitiethoadon.KhMa);
            ViewData["SpMa"] = new SelectList(_context.Sanpham, "SpMa", "SpMa", chitiethoadon.SpMa);
            return View(chitiethoadon);
        }

        // POST: Chitiethoadons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CthdMa,SpMa,HdMa,KhMa,CthdSoluong,CthdTamtinh,CthdPhigiaohang,CthdThanhtien")] Chitiethoadon chitiethoadon)
        {
            if (id != chitiethoadon.CthdMa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chitiethoadon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChitiethoadonExists(chitiethoadon.CthdMa))
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
            ViewData["HdMa"] = new SelectList(_context.Hoadon, "HdMa", "HdMa", chitiethoadon.HdMa);
            ViewData["KhMa"] = new SelectList(_context.Khachhangdat, "KhMa", "KhMa", chitiethoadon.KhMa);
            ViewData["SpMa"] = new SelectList(_context.Sanpham, "SpMa", "SpMa", chitiethoadon.SpMa);
            return View(chitiethoadon);
        }

        // GET: Chitiethoadons/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitiethoadon = await _context.Chitiethoadon
                .Include(c => c.HdMaNavigation)
                .Include(c => c.KhMaNavigation)
                .Include(c => c.SpMaNavigation)
                .FirstOrDefaultAsync(m => m.CthdMa == id);
            if (chitiethoadon == null)
            {
                return NotFound();
            }

            return View(chitiethoadon);
        }

        // POST: Chitiethoadons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var chitiethoadon = await _context.Chitiethoadon.FindAsync(id);
            _context.Chitiethoadon.Remove(chitiethoadon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChitiethoadonExists(string id)
        {
            return _context.Chitiethoadon.Any(e => e.CthdMa == id);
        }
    }
}
