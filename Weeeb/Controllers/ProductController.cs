using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Weeeb.Models;

namespace Weeeb.Controllers
{
    public class ProductController : Controller
    {
        private WeeeebContext context;
        void setDBContext()
        {
            if (context == null)
                context = HttpContext.RequestServices.GetService(typeof(WeeeebContext)) as WeeeebContext;
        }
        public IActionResult Index()
        {
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            return View();
        }
        [HttpGet]
        [Route("/Product/GetProduct/{id}")]
        public ActionResult GetProduct(int id)
        {
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            ViewModel2 s = new ViewModel2();
            s.pr = context.GetProByMa(id);
            s.rv = context.GetReByMa(id);
            ViewData.Model = s;
            var a = HttpContext.Session.GetString("username");
            ViewBag.id = context.GetIdByFname(a);
            return View();
        }
        [HttpPost]
        public ActionResult AddRev(Reviews rv)
        {
            int count;
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            count = context.AddRv(rv);
            if (count > 0)
            {
                TempData["result"] = "Thêm review thành công";
                return RedirectToAction("GetProduct", new { id = rv.product_id });
            }
            else
            {
                TempData["result"] = "Thêm review không thành công";
                return RedirectToAction("GetProduct", new { id = rv.product_id });
            }
        }
        public Products getDetailProduct(int id)
        {
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            var product = context.GetProByMa(id);
            return product;
        }
        [HttpPost]
        public IActionResult GetProduct(int id, int quantity)
        {
            var cart = HttpContext.Session.GetString("cart");//get key cart
            if (cart == null)
            {
                var product = getDetailProduct(id);
                List<CartItem> listCart = new List<CartItem>()
               {
                   new CartItem
                   {
                       Product = product,
                       Quantity = quantity
                   }
               };
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(listCart));

            }
            else
            {
                List<CartItem> dataCart = JsonConvert.DeserializeObject<List<CartItem>>(cart);
                bool check = true;
                for (int i = 0; i < dataCart.Count; i++)
                {
                    if (dataCart[i].Product.product_id == id)
                    {
                        dataCart[i].Quantity += quantity;
                        check = false;
                    }
                }
                if (check)
                {
                    dataCart.Add(new CartItem
                    {
                        Product = getDetailProduct(id),
                        Quantity = quantity
                    });
                }
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
                // var cart2 = HttpContext.Session.GetString("cart");//get key cart
                //  return Json(cart2);
            }

            return RedirectToAction(nameof(GetProduct));

        }
    }
}
