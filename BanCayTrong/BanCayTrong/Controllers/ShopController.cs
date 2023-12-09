using BanCayTrong.Data;
using BanCayTrong.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BanCayTrong.Controllers
{
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShopController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View("Login");
        }

        public IActionResult Login(string email, string matkhau)
        {
            matkhau = HashPassword(matkhau);
            NhanVien nv = _context.NhanVien.FirstOrDefault(n => n.Email == email && n.Matkhau == matkhau);
            if(nv != null)
            {
                HttpContext.Session.SetString("nhanvien", nv.Manv.ToString());
                if(nv.Quyen == 1)
                    return RedirectToAction("Index", "HomeQuanLy");
                else
                    return RedirectToAction("Index", "HomeNhanVien");
            }   
            return RedirectToAction(nameof(Index));
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
