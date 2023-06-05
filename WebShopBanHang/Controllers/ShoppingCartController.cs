using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopBanHang.Extension;
using WebShopBanHang.Models;
using WebShopBanHang.ModelView;

namespace WebShopBanHang.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly VGSShopContext _context;
        public INotyfService _notifyService { get; }
        public ShoppingCartController(VGSShopContext context, INotyfService notifyService)
        {
            _context = context;
            _notifyService = notifyService;
        }

        [Route("cart.html", Name = "Cart")]
        public IActionResult Index()
        {
            var lsGioHang = Giohang;
            return View(Giohang);
        }


        //Tạo 1 biến giỏ hàng mới, nếu giỏ hàng chưa có thì cho nó 1 giỏ hàng mới
        //Còn có rồi thì trả về giỏ hàng cho nó
        public List<CartItem> Giohang
        {
            get
            {
                var gh = HttpContext.Session.Get<List<CartItem>>("Giohang");
                if (gh == default(List<CartItem>))
                {
                    gh = new List<CartItem>();
                }
                return gh;
            }
        }


        /*
         thêm mới
        gọi sản phẩm mới
        nếu sản phẩm đó đã có thì
            đổi lại số lượng 
            lưu lại
        nếu sản phẩm đó chưa có
            gọi sản phẩm đó ra
            nếu số lg lớn hơn số lượng trong kho thì chỉ cho lấy bằng số lượng kho
            gọi giỏ mới cho nó 
                thêm số lượng
                thông tin hàng hóa
            thêm sản phẩm
            lưu lại, thông báo
        thêm thất bại thông báo lỗi
         */
        [HttpPost]
        [Route("api/cart/add")]
        public IActionResult AddToCart(int productID, int? amount)
        {
            List<CartItem> gioHang = Giohang;
            try
            {
                //Thêm sản phẩm vào Cart
                CartItem item = Giohang.SingleOrDefault(p => p.product.ProductId == productID);
                //Cart -- đã có sản sản phẩm ở trong
                if (item != null)
                {
                    item.amount = item.amount + amount.Value;
                    //Lưu lại SS
                    _notifyService.Success("Đã thêm sản phẩm thành công");
                    HttpContext.Session.Set<List<CartItem>>("Giohang", gioHang);
                }
                else
                {
                    Product hanghoa = _context.Products.AsNoTracking().SingleOrDefault(p => p.ProductId == productID);
                    if (amount > hanghoa.UnitslnStock) amount = hanghoa.UnitslnStock.Value; 
                    item = new CartItem
                    {
                        amount = amount.HasValue ? amount.Value : 1,
                        product = hanghoa

                    };
                    _notifyService.Success("Đã thêm sản phẩm thành công");
                    gioHang.Add(item);// Thêm sp vào cart
                }
                _notifyService.Success("Sản phẩm đã được thêm");
                HttpContext.Session.Set<List<CartItem>>("Giohang", gioHang);

                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }

        }

        
        /*
         * update gio hang 
         * gọi cái giỏ đó ra 
         *  nếu giỏ đó không null 
         *      cập nhật lại số lượng
         *      thông báo, lưu lại
         */
        [HttpPost]
        [Route("api/cart/update")]
        public IActionResult UpdateCart(int productID, int? amount)
        {
            //Lấy giỏ hàng ra để xử lý
            var cart = HttpContext.Session.Get<List<CartItem>>("Giohang");
            try
            {
                if (cart != null)
                {
                    CartItem item = cart.SingleOrDefault(p => p.product.ProductId == productID);
                    if (item != null && amount.HasValue) // Đã có sp => cập nhật lại số lượng
                    {
                        item.amount = amount.Value;
                    }
                    
                    //Lưu lại Session
                    _notifyService.Success("Sản phẩm đã được thêm");
                    HttpContext.Session.Set<List<CartItem>>("Giohang", cart);

                }
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }

        }


        /* Remove sản phẩm,
         *  gọi sản phẩm đó ra
         *  sản phẩm đó không null thì xóa
         *  thông báo, lưu lại
         */
        [HttpPost]
        [Route("api/cart/remove")]
        public ActionResult Remove(int productID)
        {
            try
            {
                List<CartItem> gioHang = Giohang;
                CartItem item = gioHang.SingleOrDefault(p => p.product.ProductId == productID);
                if (item != null)
                {
                    gioHang.Remove(item);
                    _notifyService.Success("Sản phẩm đã bỏ ra giỏ hàng");
                }

                //Lưu lại session 
                _notifyService.Success("Sản phẩm đã được loại ra");
                HttpContext.Session.Set<List<CartItem>>("Giohang", gioHang);

                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }
        }
        

    }
}
