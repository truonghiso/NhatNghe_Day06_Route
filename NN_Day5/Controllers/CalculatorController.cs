using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NN_Day6_Route.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calculate(double ToanHang1, double ToanHang2, string PhepToan)
        {
            double kq = 0;
            switch (PhepToan)
            {
                case "+": kq = ToanHang1 + ToanHang2; break;
                case "-": kq = ToanHang1 - ToanHang2; break;
                case "*": kq = ToanHang1 * ToanHang2; break;
                case "/": kq = ToanHang1 / ToanHang2; break;
                case "^": kq = Math.Pow(ToanHang1, ToanHang2); break;
            }

            ViewBag.A = ToanHang1;
            ViewBag.B = ToanHang2;
            ViewBag.PhepToan = PhepToan;
            ViewBag.KetQua = kq;

            return View("Index");
            //return Content($"{ToanHang1} {PhepToan} {ToanHang2} = {kq}");
        }
    }
}