using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopBanHang.Models;

namespace WebShopBanHang.ModelView
{
    public class ProductHomeVM
    {
        public Category category { get; set; }
        public List<Product> lsProduct { get; set; }

    }
}
