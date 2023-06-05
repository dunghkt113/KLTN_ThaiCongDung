using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopBanHang.Models;
using WebShopBanHang.ModelView;

namespace WebShopBanHang.Controllers
{

    public class ProductController : Controller
    {
        private readonly VGSShopContext _context;
        public ProductController(VGSShopContext context)
        {
            _context = context;
        }

        [Route("Product", Name = "ShopProduct")]

        public IActionResult Index(string sortOrder, int id, int? page , int CatID = 0)
        {
            try
            {
                ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
                ViewData["DateSortParm1"] = sortOrder == "discount" ? "date_desc" : "discount";
                HomeViewVM model = new HomeViewVM();
                var pageNumber = page == null || page <= 0 ? 1 : page.Value;
                var pageSize = 15;
                var lsProducts = _context.Products
                    .Include(x => x.Cat)
                    .AsNoTracking()
                    .OrderByDescending(x => x.DateCreated);

                PagedList<Product> models = new PagedList<Product>(lsProducts, pageNumber, pageSize);
                ViewBag.CurrentPage = pageNumber;
                ViewBag.CurrentCateID = CatID;

                return View(models);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
            
        }
        [Route("/{Alias}", Name ="ListProduct")]
        public IActionResult List(string sortOrder,string Alias, int page=1)
        {
           try
            {
                ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
                ViewData["DateSortParm1"] = sortOrder == "discount" ? "date_desc" : "discount";
                var pageSize = 10;
                var danhmuc = _context.Categories.AsNoTracking().SingleOrDefault(x => x.Alias == Alias);
                var lsProducts = _context.Products
                    .AsNoTracking()
                    .Where(x => x.CatId == danhmuc.CatId)
                    .OrderByDescending(x => x.DateCreated);

                switch (sortOrder)
                {
                    case "Date":
                        lsProducts = lsProducts.OrderBy(s => s.Price);
                        break;

                    case "discount":
                        lsProducts = lsProducts.Where(x => x.Discount.HasValue)
                            .OrderByDescending(x => x.Discount);
                        break;

                    default:
                        lsProducts = lsProducts.OrderByDescending(x => x.DateCreated);
                        break;
                }
                PagedList<Product> models = new PagedList<Product>(lsProducts, page, pageSize);
                ViewBag.CurrentPage = page;
                ViewBag.CurrentCat = danhmuc;
                return View(models);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
            

        }

        [Route("/{Alias}-{id}.html", Name = "productDetails")]
        public IActionResult Details(int id)
        {
            try
            {
                var product = _context.Products.Include(x => x.Cat).FirstOrDefault(x => x.ProductId == id);
                if (product == null)
                {
                    return RedirectToAction("Index");
                }
                var lsProduct = _context.Products
                    .AsTracking()
                    .Where(x => x.CatId == product.CatId && x.ProductId != id && x.Active == true)
                    .OrderByDescending(x=>x.DateCreated)
                    .Take(4)
                    .ToList();
                ViewBag.sanpham = lsProduct;
                return View(product);
            }

            catch { return RedirectToAction("Index", "Home"); }
           
        }
    }
}
