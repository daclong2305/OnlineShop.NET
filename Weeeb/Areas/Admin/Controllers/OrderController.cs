using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Weeeb.Models;

namespace Weeeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        /*
        public IActionResult EditBrand(int Id)
        {
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            Brands s = context.GetBraByMa(Id);
            ViewData.Model = s;
            return View();
        }
        public IActionResult EditBrand1(Brands kh)
        {
            int count;
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            count = context.UpdateBra(kh);
            if (count > 0)
                ViewData["thongbao"] = kh.brand_id;
            else
                ViewData["thongbao"] = kh.brand_id;
            return View();
        }
        */
        [HttpGet]
        public IActionResult CreateOrder()
        {
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            ViewModel7 s = new ViewModel7();
            s.p = context.GetSanPham();
            s.u = context.GetTaiKhoan();
            ViewData.Model = s;
            return View();
        }
        [HttpPost]
        public IActionResult CreateOrder(ViewModel4 u)
        {
            int count, count1;
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            count = context.AddOrd1(u.user_id, u.order_date, u.paid_status, u.status);
            User_Info v = new User_Info();
            v = context.GetTaiKhoanByMa(u.user_id);
            var a = context.GetOrd(u.user_id);
            var name = v.first_name+" "+v.last_name;
            count1 = context.AddOrdIn(a, u.user_id, name, v.mobile, v.email, v.address1, u.note);
            for (int i = u.product_id.GetLowerBound(0); i <= u.product_id.GetUpperBound(0); i++) 
            {
                int id = u.product_id[i];
                int price = context.PriceFromId(id);
                int total = price * u.quantity[i];
                int count2 = context.AddOrdIt(a,u.product_id[i],u.quantity[i],total);
                int count3 = context.UpdateStock(u.product_id[i],u.quantity[i]);
            }
            return Redirect("/Admin/Order/OrderIndex");
        }
        public IActionResult OrderIndex()
        {
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            return View(context.GetOrd());
        }
        public IActionResult DeleteOrder(int Id)
        {
            // ViewData["id"] = Id;
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            int count1 = context.XoaOrdIt(Id);
            int count2 = context.XoaOrdIn(Id);
            int count3 = context.XoaOrd(Id);
            return Redirect("OrderIndex");
        }
        public IActionResult OrderDetail(int Id)
        {
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            ViewModel5 s = context.GetOrdByMa(Id);
            ViewData.Model = s;
            return View();
        }
        public IActionResult OrderDetail1(ViewModel5 kh)
        {
            int count;
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            count = context.UpdateOrd(kh.paid_status, kh.order_date, kh.quantity, kh.total, kh.status, kh.order_id);
            if (count > 0)
            {
                TempData["result"] = "Sửa thành công";
                return Redirect("OrderIndex");
            }
            else
            {
                TempData["result"] = "Sửa không thành công";
                return Redirect("OrderIndex");
            }
        }
        public IActionResult OrderItems(int Id)
        {
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            ViewBag.oid = Id;
            return View(context.GetOrdIt(Id));
        }
        public IActionResult Items(int Id)
        {
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            var count1 = context.UpdateOrd1(Id);
            return Redirect("OrderIndex");
        }
    }
}
