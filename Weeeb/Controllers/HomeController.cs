using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Weeeb.Models;
using MailKit.Net.Smtp;
using MimeKit;

namespace Weeeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HttpContext.Session.SetString("flag","0");
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            ViewModel mymodel = new ViewModel();
            mymodel.sp1 = context.GetSanPham1();
            mymodel.sp2 = context.GetSanPham2();
            return View(mymodel);
        }
        public IActionResult Index1()
        {
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            ViewModel mymodel = new ViewModel();
            mymodel.sp1 = context.GetSanPham1();
            mymodel.sp2 = context.GetSanPham2();
            return View(mymodel);
        }

        public IActionResult Electronics()
        {
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            ViewBag.count1 = context.CountC(1);
            ViewBag.count2 = context.CountC(2);
            ViewBag.count3 = context.CountC(3);
            ViewBag.count4 = context.CountC(4);
            ViewBag.count5 = context.CountC(5);
            ViewBag.count6 = context.CountC(6);
            ViewBag.count7 = context.CountC(7);
            ViewBag.count11 = context.CountB(1);
            ViewBag.count22 = context.CountB(2);
            ViewBag.count33 = context.CountB(3);
            ViewBag.count44 = context.CountB(4);
            ViewBag.count55 = context.CountB(5);
            ViewBag.count66 = context.CountB(6);
            var s = context.GetSanPhamCat(1);
            ViewData.Model = s;
            return View();
        }
        public IActionResult Ladies()
        {
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            ViewBag.count1 = context.CountC(1);
            ViewBag.count2 = context.CountC(2);
            ViewBag.count3 = context.CountC(3);
            ViewBag.count4 = context.CountC(4);
            ViewBag.count5 = context.CountC(5);
            ViewBag.count6 = context.CountC(6);
            ViewBag.count7 = context.CountC(7);
            ViewBag.count11 = context.CountB(1);
            ViewBag.count22 = context.CountB(2);
            ViewBag.count33 = context.CountB(3);
            ViewBag.count44 = context.CountB(4);
            ViewBag.count55 = context.CountB(5);
            ViewBag.count66 = context.CountB(6);
            var s = context.GetSanPhamCat(2);
            ViewData.Model = s;
            return View();
        }
        public IActionResult Men()
        {
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            ViewBag.count1 = context.CountC(1);
            ViewBag.count2 = context.CountC(2);
            ViewBag.count3 = context.CountC(3);
            ViewBag.count4 = context.CountC(4);
            ViewBag.count5 = context.CountC(5);
            ViewBag.count6 = context.CountC(6);
            ViewBag.count7 = context.CountC(7);
            ViewBag.count11 = context.CountB(1);
            ViewBag.count22 = context.CountB(2);
            ViewBag.count33 = context.CountB(3);
            ViewBag.count44 = context.CountB(4);
            ViewBag.count55 = context.CountB(5);
            ViewBag.count66 = context.CountB(6);
            var s = context.GetSanPhamCat(3);
            ViewData.Model = s;
            return View();
        }
        public IActionResult Kids()
        {
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            ViewBag.count1 = context.CountC(1);
            ViewBag.count2 = context.CountC(2);
            ViewBag.count3 = context.CountC(3);
            ViewBag.count4 = context.CountC(4);
            ViewBag.count5 = context.CountC(5);
            ViewBag.count6 = context.CountC(6);
            ViewBag.count7 = context.CountC(7);
            ViewBag.count11 = context.CountB(1);
            ViewBag.count22 = context.CountB(2);
            ViewBag.count33 = context.CountB(3);
            ViewBag.count44 = context.CountB(4);
            ViewBag.count55 = context.CountB(5);
            ViewBag.count66 = context.CountB(6);
            var s = context.GetSanPhamCat(4);
            ViewData.Model = s;
            return View();
        }

        public IActionResult Furnitures()
        {
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            ViewBag.count1 = context.CountC(1);
            ViewBag.count2 = context.CountC(2);
            ViewBag.count3 = context.CountC(3);
            ViewBag.count4 = context.CountC(4);
            ViewBag.count5 = context.CountC(5);
            ViewBag.count6 = context.CountC(6);
            ViewBag.count7 = context.CountC(7);
            ViewBag.count11 = context.CountB(1);
            ViewBag.count22 = context.CountB(2);
            ViewBag.count33 = context.CountB(3);
            ViewBag.count44 = context.CountB(4);
            ViewBag.count55 = context.CountB(5);
            ViewBag.count66 = context.CountB(6);
            var s = context.GetSanPhamCat(5);
            ViewData.Model = s;
            return View();
        }
        public IActionResult HomeApp()
        {
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            ViewBag.count1 = context.CountC(1);
            ViewBag.count2 = context.CountC(2);
            ViewBag.count3 = context.CountC(3);
            ViewBag.count4 = context.CountC(4);
            ViewBag.count5 = context.CountC(5);
            ViewBag.count6 = context.CountC(6);
            ViewBag.count7 = context.CountC(7);
            ViewBag.count11 = context.CountB(1);
            ViewBag.count22 = context.CountB(2);
            ViewBag.count33 = context.CountB(3);
            ViewBag.count44 = context.CountB(4);
            ViewBag.count55 = context.CountB(5);
            ViewBag.count66 = context.CountB(6);
            var s = context.GetSanPhamCat(6);
            ViewData.Model = s;
            return View();
        }
        public IActionResult EGadgets()
        {
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            ViewBag.count1 = context.CountC(1);
            ViewBag.count2 = context.CountC(2);
            ViewBag.count3 = context.CountC(3);
            ViewBag.count4 = context.CountC(4);
            ViewBag.count5 = context.CountC(5);
            ViewBag.count6 = context.CountC(6);
            ViewBag.count7 = context.CountC(7);
            ViewBag.count11 = context.CountB(1);
            ViewBag.count22 = context.CountB(2);
            ViewBag.count33 = context.CountB(3);
            ViewBag.count44 = context.CountB(4);
            ViewBag.count55 = context.CountB(5);
            ViewBag.count66 = context.CountB(6);
            var s = context.GetSanPhamCat(7);
            ViewData.Model = s;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public List<Products> getAllProduct()
        {
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            return context.GetSanPham();
        }
        public Products getDetailProduct(int id)
        {
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            var product = context.GetProByMa(id);
            return product;
        }
        public IActionResult addCart(int id)
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
                       Quantity = 1
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
                        dataCart[i].Quantity++;
                        check = false;
                    }
                }
                if (check)
                {
                    dataCart.Add(new CartItem
                    {
                        Product = getDetailProduct(id),
                        Quantity = 1
                    });
                }
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
                // var cart2 = HttpContext.Session.GetString("cart");//get key cart
                //  return Json(cart2);
            }

            return RedirectToAction(nameof(Index));

        }
        public IActionResult Cart()
        {
            var cart = HttpContext.Session.GetString("cart");//get key cart
            if (cart != null)
            {
                List<CartItem> dataCart = JsonConvert.DeserializeObject<List<CartItem>>(cart);
                if (dataCart.Count > 0)
                {
                    ViewBag.carts = dataCart;
                    WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
                    if (HttpContext.Session.GetInt32("userid") != null)
                    {
                        int u = (int)HttpContext.Session.GetInt32("userid");
                        var bee = context.GetTaiKhoanByMa(u);
                        ViewData.Model = bee;
                        return View();
                    }
                    else
                    {
                        int u = 26;
                        var bee = context.GetTaiKhoanByMa(u);
                        ViewData.Model = bee;
                        return View();
                    }
                }
            }
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Checkout()
        {
            if (HttpContext.Session.GetString("flag") == "1")
            {
                var cart = HttpContext.Session.GetString("cart");//get key cart
                if (cart != null)
                {
                    List<CartItem> dataCart = JsonConvert.DeserializeObject<List<CartItem>>(cart);
                    if (dataCart.Count > 0)
                    {
                        ViewBag.carts = dataCart;
                        return View();
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return Redirect("~/Login/Index");
            }    
        }
        public IActionResult Success()
        {
            return View();
        }
        /*
        [HttpPost]
        public IActionResult Checkout(Orders_Info u)
        {
            var cart = HttpContext.Session.GetString("cart");//get key cart
            if (cart != null)
            {
                List<CartItem> dataCart = JsonConvert.DeserializeObject<List<CartItem>>(cart);
                if (dataCart.Count > 0)
                {
                    ViewBag.carts = dataCart;
                }
            }
            int count;
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            count = context.AddOrd(u);
            if (count > 0)
            {
                TempData["result"] = "Thêm user thành công";
            }
            else
            {
                TempData["result"] = "Thêm user không thành công";
            }
            return View();
        }
        */
        [HttpPost]
        public IActionResult updateCart(int id, int quantity)
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<CartItem> dataCart = JsonConvert.DeserializeObject<List<CartItem>>(cart);
                if (quantity > 0)
                {
                    for (int i = 0; i < dataCart.Count; i++)
                    {
                        if (dataCart[i].Product.product_id == id)
                        {
                            dataCart[i].Quantity = quantity;
                        }
                    }


                    HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
                }
                var cart2 = HttpContext.Session.GetString("cart");
                return Ok(quantity);
            }
            return BadRequest();

        }
        public IActionResult addCart1(int id, int quantity)
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
                        dataCart[i].Quantity+=quantity;
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

            return RedirectToAction(nameof(Index));

        }
        public IActionResult deleteCart(int id)
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<CartItem> dataCart = JsonConvert.DeserializeObject<List<CartItem>>(cart);

                for (int i = 0; i < dataCart.Count; i++)
                {
                    if (dataCart[i].Product.product_id == id)
                    {
                        dataCart.RemoveAt(i);
                    }
                }
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
                return RedirectToAction(nameof(Cart));
            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Search(string searchString)
        {
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            return View(context.GetSanPhamSearch(searchString));
        }
        [HttpPost]
        public IActionResult Price(string min, string max)
        {
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            return View(context.PriceBetween(min, max));
        }
        [HttpPost]
        public ActionResult AddOrd(ViewModel3 rv)
        {
            int count, count1, count2, count3;
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            count = context.AddOrd(rv.user_id, rv.quantity, rv.total);
            var a = context.GetOrd(rv.user_id);
            count1 = context.AddOrdIn(a, rv.user_id, rv.name, rv.phone, rv.email, rv.address, rv.note);
            var cart = HttpContext.Session.GetString("cart");
            List<CartItem> dataCart = JsonConvert.DeserializeObject<List<CartItem>>(cart);
            for (int i = 0; i < dataCart.Count; i++)
            {
                var b = dataCart[i].Quantity * dataCart[i].Product.product_price;
                count2 = context.AddOrdIt(a, dataCart[i].Product.product_id, dataCart[i].Quantity, b);
                count3 = context.UpdateStock(dataCart[i].Product.product_id, dataCart[i].Quantity);
            }

            //gui email
            MimeMessage message = new MimeMessage();

            MailboxAddress from = new MailboxAddress("Cửa hàng điện tử", "chdtuit@gmail.com");
            message.From.Add(from);

            MailboxAddress to = new MailboxAddress(rv.name, rv.email);
            message.To.Add(to);

            message.Subject = "Xác nhận đơn hàng";

            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = "<h1>Chào bạn! Bạn vừa đặt hàng tại Website</h1>";
            bodyBuilder.TextBody = "Chào bạn! Bạn vừa đặt hàng tại Website";
            message.Body = bodyBuilder.ToMessageBody();

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 465, true);
            client.Authenticate("chdtuit@gmail.com", "alo123456");

            client.Send(message);
            client.Disconnect(true);
            client.Dispose();
            //////

            return Redirect("~/Home/Success");
        }
    }
}
