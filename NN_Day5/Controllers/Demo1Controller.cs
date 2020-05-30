using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NN_Day6_Route.Models;

namespace NN_Day5.Controllers
{
    public class Demo1Controller : Controller
    {
        public IActionResult TruyenDuLieu()
        {
            ViewBag.NgayThanhLap = new DateTime(2003, 3, 10);
            ViewBag.Ten = "Nhất Nghệ";

            //ViewData nhận [key value]:
            ViewData["Tuoi"] = 17;
            ViewData["Phone"] = "0707459367";

            ViewBag.SanPham = new HangHoa
            {
                MaHH = 1, TenHH = "Bia Sài Gòn",
                DonGia = 18900, GiamGia = 3
            };
            return View();
        }

        [Route("/dien-thoai/{tenDienThoai}")]

        public IActionResult ChiTiet(string tenDienThoai)
        {
            return Content(tenDienThoai);
        }

        [Route("/{loai}/{sanpham}")]
        public IActionResult ChiTiet(string loai, string sanpham)
        {
            return Content($"{loai} - {sanpham}");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}