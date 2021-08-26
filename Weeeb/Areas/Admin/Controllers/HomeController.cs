using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weeeb.Models;

namespace Weeeb.Areas.Admin.Controllers
{[Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            ViewBag.countord0 = context.CountOrder0();
            ViewBag.countpro = context.CountPro();
            ViewBag.countpro5 = context.CountProSto5();
            ViewBag.countpro0 = context.CountProSto0();
            ViewBag.countordall = context.CountOrderAll();
            ViewBag.countord1 = context.CountOrder1();
            ViewBag.soldpro = context.CountSoldPro();
            ViewBag.countrev = context.CountRev();
            ViewBag.sum = context.Sum();
            ViewBag.user = context.CountU();
            ViewBag.countproall = context.CountProAll();
            ViewBag.brand = context.CountBrand();
            return View(context.GetTopUser());
        }
    }
}
