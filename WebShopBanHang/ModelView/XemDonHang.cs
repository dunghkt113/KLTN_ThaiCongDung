using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopBanHang.Models;

namespace WebShopBanHang.ModelView
{
    public class XemDonHang
    {
        public Order DonHang { get; set; }
        public List<OrderDetail> ChiTietDonHang { get; set; }
    }
}
