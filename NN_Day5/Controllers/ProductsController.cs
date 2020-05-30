using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NN_Day6_Route.Models;

namespace NN_Day6_Route.Controllers
{
    public class ProductsController : Controller
    {
        static List<HangHoa> dsHangHoa = new List<HangHoa>();

        public ProductsController()
        {
            dsHangHoa.Add(new HangHoa
            {
                MaHH = 1,
                TenHH = "Bánh Mì",
                DonGia = 45900,
                GiamGia = 1
            });
            dsHangHoa.Add(new HangHoa
            {
                MaHH = 2,
                TenHH = "Mì Xào Bò",
                DonGia = 41000,
                GiamGia = 5
            });
        }

        public IActionResult Index()
        {
            return View(dsHangHoa);
        }

        [HttpPost]
        public IActionResult Create(HangHoa hanghoa)
        {
            dsHangHoa.Add(hanghoa);
            return View ("Index", dsHangHoa);
            //return Redirect("/HangHoa");
            //return RedirectToAction("Index", "HangHoa");
        }

        public IActionResult Create()
        {
            return View(dsHangHoa);
        }
    }
}