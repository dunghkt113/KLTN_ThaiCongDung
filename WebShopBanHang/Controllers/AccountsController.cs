using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebShopBanHang.Enums;
using WebShopBanHang.Extension;
using WebShopBanHang.Helpper;
using WebShopBanHang.Models;
using WebShopBanHang.ModelView;

namespace WebShopBanHang.Controllers
{
    [Authorize]

    public class AccountsController : Controller
    {
        private readonly VGSShopContext _context;
        public INotyfService _notifyService { get; }
        public AccountsController(VGSShopContext context, INotyfService notifyService)
        {
            _context = context;
            _notifyService = notifyService;
        }


        [Route("tai-khoan-cua-toi.html", Name = "Dashboard")]
        public IActionResult Dashboard()
        {
            var taikhoanID = HttpContext.Session.GetString("CustomerId");
            if (taikhoanID != null)
            {
                var khachhang = _context.Customers.AsNoTracking()
                    .SingleOrDefault(x => x.CustomerId == Convert.ToInt32(taikhoanID));
                if (khachhang != null)
                {
                    var lsDonhang = _context.Orders
                        .Include(x => x.TransactStatus)
                        .AsNoTracking()
                        .Where(x => x.CustomerId == khachhang.CustomerId)
                        .OrderByDescending(x => x.OrderDate).ToList();
                    ViewBag.DonHang = lsDonhang;
                    return View(khachhang);
                }
            }
            return RedirectToAction("Login");
        }
        [HttpGet]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public IActionResult ValidatePhone(string Phone)
        {
            try
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.Phone.ToLower() == Phone.ToLower());
                if (khachhang != null)
                    return Json(data: "Số điện thoại : " + Phone + "Đã được sử dụng");
                return Json(data: true);
            }
            catch
            {
                return Json(data: true);
            }
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ValidateEmail(string Email)
        {
            try
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.Email.ToLower() == Email.ToLower());
                if (khachhang != null)
                    return Json(data: "Email : " + Email + "Đã được sử dụng");
                return Json(data: true);
            }
            catch
            {
                return Json(data: true);
            }
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("dang-ky.html", Name = "Dangky")]
        public IActionResult DangKyTaiKhoan()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        [Route("dang-ky.html", Name = "Dangky")]
        public async Task<IActionResult> DangKyTaiKhoan(RegisterVM taikhoan, string Email)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string salt = Utilities.GetRandomKey();
                    Customer khachhang = new Customer
                    {
                        FullName = taikhoan.FullName,
                        Phone = taikhoan.Phone.Trim().ToLower(),
                        Email = taikhoan.Email.Trim().ToLower(),
                        Adress = taikhoan.Address,
                        Password = (taikhoan.Password + salt.Trim()).ToMD5(),
                        Active = true,
                        Salt = salt,
                        CreateDate = DateTime.Now
                    };
                    var kh = _context.Customers.AsNoTracking().SingleOrDefault(x => x.Email.ToLower() == Email.ToLower());
                    if (kh != null)
                    {
                        ViewBag.Alert = Utilities.ShowAlert(CacheKeys.Danger, "Email không đã tồn tại.");
                        return View(taikhoan);
                    }
                    else
                    {
                        try
                        {
                            //Đăng nhập thành công -- lưu thời gian đăng nhập lại
                            khachhang.LastLogin = DateTime.Now;
                            _context.Add(khachhang);
                            await _context.SaveChangesAsync();
                            //Lưu Session Mã Khách hàng
                            HttpContext.Session.SetString("CustomerId", khachhang.CustomerId.ToString());
                            var taikhoanID = HttpContext.Session.GetString("CustomerId");
                            var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, khachhang.FullName),
                            new Claim("CustomerId", khachhang.CustomerId.ToString())
                        };
                            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "login");
                            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                            await HttpContext.SignInAsync(claimsPrincipal);
                            _notifyService.Success("Đăng ký tài khoản thành công");
                            return RedirectToAction("Dashboard", "Accounts");
                        }
                        catch
                        {
                            return RedirectToAction("DangKyTaiKhoan", "Accounts");
                        }
                    }
                }
                else
                {
                    return View(taikhoan);
                }
            }
            catch
            {
                _notifyService.Error("Đăng ký tài khoản thất bại");
                return View(taikhoan);
            }
        }


        [HttpGet]
        [AllowAnonymous]
        [Route("dang-nhap.html", Name = "DangNhap")]
        public IActionResult Login(string returnUrl = null)
        {
            var taikhoanID = HttpContext.Session.GetString("CustomerId");

            if (taikhoanID != null)
            {
                return RedirectToAction("DangKyTaiKhoan", "Accounts");

            }
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("dang-nhap.html", Name = "DangNhap")]
        public async Task<IActionResult> Login(LoginViewModel customer, string returnUrl = null)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isEmail = Utilities.IsValidEmail(customer.Email);
                    if (!isEmail) return View(customer);
                    var khachhang = _context.Customers
                            .AsNoTracking()
                            .SingleOrDefault(x => x.Email.Trim() == customer.Email.Trim());
                    if (khachhang == null)
                    {
                        _notifyService.Error("Rất tiếc chúng tôi không tìm thấy Email của bạn");
                        return View(customer);
                    }
                    string pass = (customer.Password + khachhang.Salt.Trim()).ToMD5();
                    if (khachhang.Password != pass)
                    {
                        _notifyService.Error("Thông tin đăng nhập không chính xác");
                        return View(customer);
                    }
                    //Kiểm tra tài khoản có được Active hay là không
                    if (khachhang.Active == false) return RedirectToAction("Thongbao", "Accounts");

                    //Đăng nhập thành công -- lưu thời gian đăng nhập lại
                    khachhang.LastLogin = DateTime.Now;
                    _context.Update(khachhang);
                    await _context.SaveChangesAsync();

                    //Lưu Session MaKh
                    HttpContext.Session.SetString("CustomerId", khachhang.CustomerId.ToString());
                    var taiKhoanID = HttpContext.Session.GetString("CustomerId");
                    //Identity
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, khachhang.FullName),
                        new Claim("CustomerId", khachhang.CustomerId.ToString()),
                    };
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "login");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    await HttpContext.SignInAsync(claimsPrincipal);
                    ViewBag.ReturnUrl = returnUrl;
                    if (string.IsNullOrEmpty(returnUrl))
                    {
                        _notifyService.Success("Đăng nhập thành công");
                        return RedirectToAction("Dashboard", "Accounts");
                    }
                    else
                    {
                        return Redirect(returnUrl);
                    }
                }
            }
            catch
            {
                return RedirectToAction("DangKyTaiKhoan", "Accounts");
            }
            return View(customer);
        }

        [HttpGet]
        [Route("dang-xuat.html", Name = "Logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            HttpContext.Session.Remove("CustomerId");
            _notifyService.Success("Đăng xuất thành công");
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordViewModel model)
        {
            try
            {
                var taikhoanID = HttpContext.Session.GetString("CustomerId");
                if (taikhoanID == null)
                {
                    return RedirectToAction("Login", "Accounts");
                }
                if (ModelState.IsValid)
                {
                    var taikhoan = _context.Customers.Find(Convert.ToInt32(taikhoanID));
                    if (taikhoan == null) return RedirectToAction("Login", "Accounts");

                    var pass = (model.PasswordNow.Trim() + taikhoan.Salt.Trim()).ToMD5();
                    if (pass == taikhoan.Password)
                    {
                        string passnew = (model.Password.Trim() + taikhoan.Salt.Trim()).ToMD5();
                        taikhoan.Password = passnew;
                        _context.Update(taikhoan);
                        _context.SaveChanges();
                        _notifyService.Success("Đổi mật khẩu thành công");

                        return RedirectToAction("Dashboard", "Accounts");
                    }
                }
            }
            catch
            {
                _notifyService.Error("Đổi mật khẩu không thành công");
                return RedirectToAction("Dashboard", "Accounts");
            }
            _notifyService.Error("Đổi mật khẩu không thành công");
            return RedirectToAction("Dashboard", "Accounts");
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.TransactStatus)
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }

            var chitietdonhang = _context.OrderDetails
                .Include(x => x.Product)
                .AsNoTracking()
                .Where(x => x.OrderId == order.OrderId)
                .OrderBy(x => x.OrderDetailId)
                .ToList();
            ViewBag.ChiTiet = chitietdonhang;
            return View(order);
        }
        
    }
}
