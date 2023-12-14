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
            ViewData["valuengaybatdau"] = ngaybatdau.ToString("yyyy-MM-dd");
            ViewData["valuengayketthuc"] = ngayketthuc.ToString("yyyy-MM-dd");
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

        public IActionResult HoaDonChuaDuyet()
        {
            var lstHoaDon = _context.HoaDon
                            .Include(k => k.MakhNavigation)
                            .Include(d => d.MadcNavigation)
                            .Where(h => h.Trangthai == 0);

            GetInfo();
            return View(lstHoaDon);
        }

        public IActionResult HoaDonDaDuyet()
        {
            var lstHoaDon = _context.HoaDon
                            .Include(k => k.MakhNavigation)
                            .Include(d => d.MadcNavigation)
                            .Where(h => h.Trangthai == 1);

            GetInfo();
            return View(lstHoaDon);
        }

        public IActionResult HoaDonDaHuy()
        {
            var lstHoaDon = _context.HoaDon
                            .Include(k => k.MakhNavigation)
                            .Include(d => d.MadcNavigation)
                            .Where(h => h.Trangthai == 2);

            GetInfo();
            return View(lstHoaDon);
        }



        public IActionResult ChiTietHoaDonChuaDuyet(int id)
        {
            HoaDon hd = _context.HoaDon
                        .Include(k => k.MakhNavigation)
                        .Include(d => d.MadcNavigation)
                        .FirstOrDefault(h => h.Mahd == id);
            var lstCTHoaDon = _context.CthoaDon.Include(c => c.MamhNavigation).Where(h => h.Mahd == id);
            ViewBag.chittiethoadon = lstCTHoaDon;
            GetInfo();
            return View(hd);
        }

        public IActionResult ChiTietHoaDonDaDuyet(int id)
        {
            HoaDon hd = _context.HoaDon
                        .Include(k => k.MakhNavigation)
                        .Include(d => d.MadcNavigation)
                        .FirstOrDefault(h => h.Mahd == id);
            var lstCTHoaDon = _context.CthoaDon.Include(c => c.MamhNavigation).Where(h => h.Mahd == id);
            ViewBag.chittiethoadon = lstCTHoaDon;
            GetInfo();
            return View(hd);
        }

        public IActionResult ChiTietHoaDonDaHuy(int id)
        {
            HoaDon hd = _context.HoaDon
                        .Include(k => k.MakhNavigation)
                        .Include(d => d.MadcNavigation)
                        .FirstOrDefault(h => h.Mahd == id);
            var lstCTHoaDon = _context.CthoaDon.Include(c => c.MamhNavigation).Where(h => h.Mahd == id);
            ViewBag.chittiethoadon = lstCTHoaDon;
            GetInfo();
            return View(hd);
        }

        public async Task<IActionResult> DuyetDonHang(int id)
        {
            HoaDon hd = _context.HoaDon.FirstOrDefault(h => h.Mahd == id);
            hd.Trangthai = 1;
            _context.Update(hd);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(HoaDonChuaDuyet));
        }

        public async Task<IActionResult> HuyDonHang(int id)
        {
            HoaDon hd = _context.HoaDon.FirstOrDefault(h => h.Mahd == id);
            hd.Trangthai = 2;
            _context.Update(hd);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(HoaDonChuaDuyet));
        }

        public IActionResult ProfileNhanVien()
        {
            GetInfo();
            return View();
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.SetString("nhanvien", "");
            return RedirectToAction("Index", "Home");

        }    

    }
}
