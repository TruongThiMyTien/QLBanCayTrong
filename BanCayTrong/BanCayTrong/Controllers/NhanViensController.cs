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
using Microsoft.AspNetCore.Identity;
using System.Security.Cryptography;
using System.Text;

namespace BanCayTrong.Controllers
{
    public class NhanViensController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NhanViensController(ApplicationDbContext context)
        {
            _context = context;
        }

        public void GetInfo()
        {
            ViewBag.nhanvien = _context.NhanVien.FirstOrDefault(n => n.Manv.ToString() == HttpContext.Session.GetString("nhanvien"));
        }

        // GET: NhanViens
        public async Task<IActionResult> Index()
        {
            GetInfo();
            return View(await _context.NhanVien.ToListAsync());
        }

        // GET: NhanViens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanVien = await _context.NhanVien
                .FirstOrDefaultAsync(m => m.Manv == id);
            if (nhanVien == null)
            {
                return NotFound();
            }
            GetInfo();
            return View(nhanVien);
        }

        // GET: NhanViens/Create
        public IActionResult Create()
        {
            GetInfo();
            return View();
        }

        // POST: NhanViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Manv,Ten,Dienthoai,Email,Matkhau,Quyen")] NhanVien nhanVien, int quyen, string matkhau)
        {
            if (ModelState.IsValid)
            {
                if(quyen == 1)
                {
                    nhanVien.Quyen = 1;
                }
                else
                {
                    nhanVien.Quyen = 0;
                }
                nhanVien.Matkhau = HashPassword(matkhau);
                _context.Add(nhanVien);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            GetInfo();
            return View(nhanVien);
        }

        // GET: NhanViens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanVien = await _context.NhanVien.FindAsync(id);
            if (nhanVien == null)
            {
                return NotFound();
            }
            GetInfo();
            return View(nhanVien);
        }

        // POST: NhanViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit( int manv, string ten, string dienthoai, string email, string matkhau, string matkhaumoi, int quyen)
        {
            var nhanVien = await _context.NhanVien.FirstOrDefaultAsync(m => m.Manv == manv);
            if(nhanVien != null)
            {
                nhanVien.Ten = ten;
                nhanVien.Dienthoai = dienthoai;
                nhanVien.Email = email;
                if(matkhaumoi != null)
                {
                    nhanVien.Matkhau = HashPassword(matkhaumoi);
                }
                else {
                    nhanVien.Matkhau = matkhau;       
                }

                if (quyen == 1){
                    nhanVien.Quyen = 1;
                }else{
                    nhanVien.Quyen = 0;
                }
                _context.Update(nhanVien);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return NotFound();
        }

        // GET: NhanViens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanVien = await _context.NhanVien
                .FirstOrDefaultAsync(m => m.Manv == id);
            if (nhanVien == null)
            {
                return NotFound();
            }
            GetInfo();
            return View(nhanVien);
        }

        // POST: NhanViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nhanVien = await _context.NhanVien.FindAsync(id);
            _context.NhanVien.Remove(nhanVien);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NhanVienExists(int id)
        {
            return _context.NhanVien.Any(e => e.Manv == id);
        }

        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}
