using WebShopBanHang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopBanHang.ModelView
{
    public class HomeViewVM
    {
        public List<ProductHomeVM> Products { get; set; }

        public List<News> News { get; set; }
        public List<Banner> Banners { get; set; }
        public Category category { get; set; }

    }
}
