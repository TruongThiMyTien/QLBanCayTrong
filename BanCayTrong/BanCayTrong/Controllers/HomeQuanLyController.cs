using BanCayTrong.Data;
using BanCayTrong.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BanCayTrong.Controllers
{
    public class HomeQuanLyController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IPasswordHasher<KhachHang> _passwordHasher;

        public HomeQuanLyController(ApplicationDbContext context, IPasswordHasher<KhachHang> passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
        }
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Nhanviens");
        }
    }
}
