using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Weeeb.Models;

namespace Weeeb.Controllers
{
    public class LoginController : Controller
    {
        private WeeeebContext context;
        void setDBContext()
        {
            if (context == null)
                context = HttpContext.RequestServices.GetService(typeof(WeeeebContext)) as WeeeebContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
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
            else if (kq == -1)
            {
                TempData["result"] = "Đăng nhập không thành công";
                return RedirectToAction("Index", "Login");
            }
            string a = context.GetFname(email, password);
            int b = context.GetId(email, password);
            TempData["userlogin"] = a;
            HttpContext.Session.SetString("flag","1");
            HttpContext.Session.SetString("username", a);
            HttpContext.Session.SetInt32("userid", b);
            return Redirect("~/Home/Index1");
        }
        [HttpGet]
        public IActionResult Profile()
        {
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            int a = 0;
            if (HttpContext.Session.GetInt32("userid") != null)
            {
                a = (int)HttpContext.Session.GetInt32("userid");
            }
            else
            {
                a = 26;
            }
            ViewModel8 s = new ViewModel8();
            s.u = context.GetTaiKhoanByMa(a);
            s.o = context.GetOrdByMaUser(a);
            ViewData.Model = s;
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User_Info u)
        {
            int count;
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            count = context.AddUser(u);
            if (count > 0)
            {
                TempData["result"] = "Thêm user thành công";
            }
            else
            {
                TempData["result"] = "Thêm user không thành công";
            }
            return RedirectToAction("Index", "Login");
        }
        [HttpGet]
        public IActionResult ChangePass()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ChangePass(Pass p)
        {
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            int a = 0, count = 0;
            if (HttpContext.Session.GetInt32("userid") != null)
            {
                a = (int)HttpContext.Session.GetInt32("userid");
            }
            else
            {
                a = 26;
            }
            var b = context.GetPass(a);
            if(b==p.cu_pass)
            {
                if(p.ne_pass==p.re_pass)
                {
                    count = context.UpdatePass(a,p.ne_pass);
                    if (count > 0)
                    {
                        ViewBag.thay = "Thay pass thành công";
                    }
                    else
                    {
                        ViewBag.thay = "Thay pass không thành công";
                    }
                }
            }
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return Redirect("~/Home/Index1");
        }
    }
}
