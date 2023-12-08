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
using System.IO;

namespace BanCayTrong.Controllers
{
    public class MatHangsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MatHangsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MatHangs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.MatHang.Include(m => m.MadmNavigation);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: MatHangs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matHang = await _context.MatHang
                .Include(m => m.MadmNavigation)
                .FirstOrDefaultAsync(m => m.Mamh == id);
            if (matHang == null)
            {
                return NotFound();
            }

            return View(matHang);
        }

        // GET: MatHangs/Create
        public IActionResult Create()
        {
            ViewData["Madm"] = new SelectList(_context.DanhMuc, "Madm", "Ten");
            return View();
        }

        // POST: MatHangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Mamh,Ten,Giagoc,Giaban,Soluong,Mota,Hinhanh,Madm")] MatHang matHang, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                matHang.Hinhanh = UploadHinhAnh(file);
                _context.Add(matHang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Madm"] = new SelectList(_context.DanhMuc, "Madm", "Ten", matHang.Madm);
            return View(matHang);
        }

        // GET: MatHangs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matHang = await _context.MatHang.FindAsync(id);
            if (matHang == null)
            {
                return NotFound();
            }
            ViewData["Madm"] = new SelectList(_context.DanhMuc, "Madm", "Ten", matHang.Madm);
            return View(matHang);
        }

        // POST: MatHangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Mamh,Ten,Giagoc,Giaban,Soluong,Mota,Hinhanh,Madm")] MatHang matHang, IFormFile file)
        {
            if (id != matHang.Mamh)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if(file != null)
                    {
                        matHang.Hinhanh = UploadHinhAnh(file);
                    }    
                    _context.Update(matHang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MatHangExists(matHang.Mamh))
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
            ViewData["Madm"] = new SelectList(_context.DanhMuc, "Madm", "Ten", matHang.Madm);
            return View(matHang);
        }

        // GET: MatHangs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matHang = await _context.MatHang
                .Include(m => m.MadmNavigation)
                .FirstOrDefaultAsync(m => m.Mamh == id);
            if (matHang == null)
            {
                return NotFound();
            }

            return View(matHang);
        }

        // POST: MatHangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var matHang = await _context.MatHang.FindAsync(id);
            _context.MatHang.Remove(matHang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MatHangExists(int id)
        {
            return _context.MatHang.Any(e => e.Mamh == id);
        }
        public string UploadHinhAnh(IFormFile file)
        {
            string uploadFileName = null;
            if (file != null)
            {

                uploadFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                var path = $"wwwroot\\images\\mathang\\{uploadFileName}";
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

            }
            return uploadFileName;
        }
    }
}
