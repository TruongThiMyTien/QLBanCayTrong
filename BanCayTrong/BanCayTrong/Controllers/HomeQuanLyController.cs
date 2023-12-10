using BanCayTrong.Data;
using BanCayTrong.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Threading.Tasks;

namespace BanCayTrong.Controllers
{
    public class HomeQuanLyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeQuanLyController(ApplicationDbContext context)
        {
            _context = context;
        }
        public void GetInfo()
        {
            ViewBag.nhanvien = _context.NhanVien.FirstOrDefault(n => n.Manv.ToString() == HttpContext.Session.GetString("nhanvien"));
        }

        public IActionResult Index()
        {
            GetInfo();
            return View();
        }

        
        public IActionResult ThongKeThoiGian()
        {
            GetInfo();
            return View();
        }

        public IActionResult submitThongKeThoiGian(DateTime ngaybatdau, DateTime ngayketthuc)
        {
            var lstHoaDon = _context.HoaDon.Include(m => m.MakhNavigation)
                            .Where(h => ((h.Ngay).Date >= ngaybatdau.Date) && ((h.Ngay).Date <= ngayketthuc.Date) && h.Trangthai == 1);
            int tongtien = 0;
            foreach(HoaDon hd in lstHoaDon)
            {
                tongtien += hd.Tongtien;
            }
            ViewData["ngaybatdau"] = ngaybatdau.Month + "/" + ngaybatdau.Day + "/" + ngaybatdau.Year;
            ViewData["ngayketthuc"] = ngayketthuc.Month + "/" + ngayketthuc.Day + "/" + ngayketthuc.Year;
            ViewData["tongtien"] = tongtien.ToString("n0");
            GetInfo();
            return View(lstHoaDon);
        }

        public IActionResult ThongKeKhachHang()
        {
            GetInfo();
            return View();
        }

        public IActionResult submitThongKeKhachHang(string emailkhachhang)
        {
            var lstHoaDon = _context.HoaDon.Include(m => m.MakhNavigation)
                            .Where(h => h.MakhNavigation.Email == emailkhachhang && h.MakhNavigation.Matkhau != null && h.Trangthai == 1);
            int tongtien = 0;
            foreach (HoaDon hd in lstHoaDon)
            {
                tongtien += hd.Tongtien;
            }
            ViewBag.ttkhachhang = _context.KhachHang.FirstOrDefault(k => k.Email == emailkhachhang && k.Matkhau != null);
            ViewData["tongtien"] = tongtien.ToString("n0");
            GetInfo();
            return View(lstHoaDon);
        }

        public IActionResult ThongKeMatHang()
        {
            GetInfo();
            return View();
        }

        public IActionResult submitThongKeMatHang(int mamathang)
        {
            var lstHoaDon = _context.CthoaDon.Include(m => m.MahdNavigation)
                            .Where(h => h.Mamh == mamathang && h.MahdNavigation.Trangthai == 1);
            int tongtien = 0;
            foreach (CthoaDon hd in lstHoaDon)
            {
                tongtien += hd.Thanhtien;
            }
            ViewBag.ttmathang = _context.MatHang.FirstOrDefault(m => m.Mamh == mamathang);
            ViewData["tongtien"] = tongtien.ToString("n0");
            GetInfo();
            return View(lstHoaDon);
        }

    }
}
