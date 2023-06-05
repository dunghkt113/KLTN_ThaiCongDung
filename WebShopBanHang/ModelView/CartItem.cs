using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopBanHang.Models;

namespace WebShopBanHang.ModelView
{
    public class CartItem
    {
        public Product product { get; set; }
        public int amount { get; set; }
        public decimal TotalMoney => amount * product.Price;
    }
}
