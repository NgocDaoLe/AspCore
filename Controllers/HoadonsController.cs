using System.Security.Authentication.ExtendedProtection;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using shophoatuoi.Models;
//using extention 

namespace shophoatuoi.Controllers
{
    public class HoadonsController : Controller
    {
        private readonly acomptec_shophoaContext _context = new acomptec_shophoaContext();

        // GET: Hoadons
        public async Task<IActionResult> Index()
        {
            return View(await _context.Hoadon.ToListAsync());
        }

        // GET: Hoadons/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoadon = await _context.Hoadon
                .FirstOrDefaultAsync(m => m.HdMa == id);
            if (hoadon == null)
            {
                return NotFound();
            }

            return View(hoadon);
        }
        // GET: Chitiethoadons/Print/5
        // public static class Extensions
        // {
        //     public static IQueryable<Hoadon> CompleteHoaDon(this acomptec_shophoaContext _context)
        //     {
        //             return _context.Hoadon
        //                 .Include(c => c.Chitiethoadon);
                        
        //         }

        //     public static Hoadon CompanyById(this acomptec_shophoaContext _context, string id)
        //     {
        //         return _context.Hoadon
        //             .Include(c => c.Chitiethoadon)
        //             .FirstOrDefault(c => c.HdMa == id) ;
        //     }

        // }
        public async Task<IActionResult> Print(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoadon = await _context.Hoadon
                .Include(c => c.Chitiethoadon)
                
                // chỗ này để model sản phẩm để lấy ra tên sp
                .FirstOrDefaultAsync(m => m.HdMa == id);
            if (hoadon == null)
            {
                return NotFound();
            }

            return View(hoadon);
        }
               
        // GET: Hoadons/Create
        public IActionResult Create()
        {
            int MIN = 0001;
            int MAX = 9999;
            Random RD = new Random();
            Hoadon obj = new Hoadon();
            obj.HdMa = RD.Next(MIN, MAX).ToString();
            return View(obj);
        }

        // POST: Hoadons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HdMa,HdNgaydat,HdNgyagiao,HdDiachinguoinhan,HdTennguoinhan,HdSdtnguoinhan")] Hoadon hoadon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hoadon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hoadon);
        }

        // GET: Hoadons/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoadon = await _context.Hoadon.FindAsync(id);
            if (hoadon == null)
            {
                return NotFound();
            }
            return View(hoadon);
        }

        // POST: Hoadons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("HdMa,HdNgaydat,HdNgyagiao,HdDiachinguoinhan,HdTennguoinhan,HdSdtnguoinhan")] Hoadon hoadon)
        {
            if (id != hoadon.HdMa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hoadon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HoadonExists(hoadon.HdMa))
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
            return View(hoadon);
        }

        // GET: Hoadons/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoadon = await _context.Hoadon
                .FirstOrDefaultAsync(m => m.HdMa == id);
            if (hoadon == null)
            {
                return NotFound();
            }

            return View(hoadon);
        }

        // POST: Hoadons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var hoadon = await _context.Hoadon.FindAsync(id);
            _context.Hoadon.Remove(hoadon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HoadonExists(string id)
        {
            return _context.Hoadon.Any(e => e.HdMa == id);
        }
    }
}
