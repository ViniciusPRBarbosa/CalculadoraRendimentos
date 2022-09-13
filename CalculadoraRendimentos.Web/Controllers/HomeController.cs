using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Future_Value_Calculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FutureValue = "";
            return View();
        }

        [HttpPost]
        public IActionResult Index(Models.ValorAcumulado fv)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FutureValue = fv.CalcularValorAcumulado().ToString("c2");
            }
            else
            {
                ViewBag.FutureValue = "";
            }

            return View();
        }
    }
}
