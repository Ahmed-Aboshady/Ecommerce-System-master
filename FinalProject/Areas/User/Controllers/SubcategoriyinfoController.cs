using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Area("User")]

    public class SubcategoriyinfoController : Controller
    {
        private ApplicationDbContext db;

        public SubcategoriyinfoController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var categories = db.MainCategories.Take(3);
            //var subcat = db.SubCategories.Where(x => categories.Any(xx=>xx.mainCategoryId==x.mainCategoryId)).Take(10);
            return View(categories);
        }

        [HttpPost]
        public JsonResult search(string Prefix)
        {

            var productlist = db.Products.Where(x => x.productName.ToLower().Contains(Prefix.ToLower()))
                .Select(x => new { productName = x.productName, ID = x.productId }).ToList();

            return Json(productlist);
        }

    }
}
