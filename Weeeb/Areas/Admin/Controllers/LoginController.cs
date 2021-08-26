using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Weeeb.Models;

namespace Weeeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string email, string password)
        {
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            int kq = context.Login(email, password);
            if (kq == 1)
            {
                return Redirect("/Admin/Home/Index");
                //return RedirectToAction("Index", "Home");
            }
            else if(kq == 2)
            {
                return Redirect("/Staff/Home/Index");
            }
            else
            {
                TempData["result"] = "Đăng nhập không thành công";
                return Redirect("/Admin/Login/Index");
            }
        }
    }
}
