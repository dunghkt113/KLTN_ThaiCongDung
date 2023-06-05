using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopBanHang.Models;

namespace WebShopBanHang.ModelView
{
    public class MuaHangSuccessVM
    {
        public int DonHangID { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string PhuongXa { get; set; }
        public string QuanHuyen { get; set; }
        public string TinhThanh { get; set; }

        public OrderDetail OrderDT { get; set; }
        public Order DonHang { get; set; }
    }
}
