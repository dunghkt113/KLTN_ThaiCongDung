using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopBanHang.Extension;
using WebShopBanHang.ModelView;

namespace WebShopBanHang.Controllers.Components
{
    public class HeaderCartViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("Giohang");
            return View(cart);
        }
    }
}
