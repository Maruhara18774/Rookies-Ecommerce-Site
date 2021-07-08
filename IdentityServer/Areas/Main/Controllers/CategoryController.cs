using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer.Data.Models;

namespace IdentityServer.Areas.Main.Controllers
{
    [Area("Main")]
    public class CategoryController : Controller
    {
        private readonly Data.ApplicationDbContext _context;
        public CategoryController(Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            string key = RouteData.Values["id"].ToString();
            if (key == "Clothing")
            {
                return RedirectToAction("Clothing");
            }
            return View();
        }
        public IActionResult Clothing()
        {
            return View();
        }
        public IActionResult ListProducts()
        {
            string key = RouteData.Values["id"].ToString();
            var lsProduct = _context.Products.Where(p => p.SubCategory.Category.Category_Name == key).ToList();
            List<Size> lsSize = new List<Size>();
            foreach(var item in lsProduct)
            {
                foreach(var size in item.Sizes)
                {
                    if (!lsSize.Contains(size))
                    {
                        lsSize.Add(size);
                    }
                }
                
            }
            ViewData["Sizes"] = lsSize;
            return View(lsProduct);
        }
        public IActionResult ListSizes() => PartialView("_SortBySize");
    }
}
