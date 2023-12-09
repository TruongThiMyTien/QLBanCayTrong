using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BanCayTrong.Data;
using BanCayTrong.Models;
using Microsoft.AspNetCore.Http;

namespace BanCayTrong.Controllers
{
    public class KhachHangsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KhachHangsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public void GetInfo()
        {
            ViewBag.nhanvien = _context.NhanVien.FirstOrDefault(n => n.Manv.ToString() == HttpContext.Session.GetString("nhanvien"));
        }


        // GET: KhachHangs
        public async Task<IActionResult> Index()
        {
            GetInfo();
            return View(await _context.KhachHang.ToListAsync());
        }

        // GET: KhachHangs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachHang = await _context.KhachHang
                .FirstOrDefaultAsync(m => m.Makh == id);
            if (khachHang == null)
            {
                return NotFound();
            }
            GetInfo();
            return View(khachHang);
        }

        // GET: KhachHangs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachHang = await _context.KhachHang
                .FirstOrDefaultAsync(m => m.Makh == id);
            if (khachHang == null)
            {
                return NotFound();
            }
            GetInfo();
            return View(khachHang);
        }

        // POST: KhachHangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var khachHang = await _context.KhachHang.FindAsync(id);
            khachHang.Daxoa = 1;
            _context.KhachHang.Update(khachHang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KhachHangExists(int id)
        {
            return _context.KhachHang.Any(e => e.Makh == id);
        }
    }
}
