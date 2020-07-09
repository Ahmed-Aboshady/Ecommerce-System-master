using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Areas.User.Controllers
{
    [Area("User")]

    public class subCategoryDataController : Controller
    {
        private ApplicationDbContext context;


        //Constructor
        public subCategoryDataController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult getsubcategoryData(int id)
        {
             
            if (id == 0)
            {
                var products = context.Products.ToList();
                return View(products);
            }

            var products1 = context.Products.Where(p => p.subCategoryId == id).ToList();
            return View(products1);
        }


        //filter products by price
        public IActionResult FilterByPrice(int priceRange)
        {
            //get products with price less than or equal to filtering price
            var FilteredProducts = context.Products.Where(p => p.productPrice <= priceRange).ToList();
            return PartialView(FilteredProducts);
        }

        //filter products by Discount
        public IActionResult FilterByDiscount(int Discount)
        {
            
            //get products with price less than or equal to filtering price
            var FilteredProducts = context.Products.Where(p => p.discountValue <= Discount).ToList();
            return PartialView(FilteredProducts);
        }

        //filter products by Rate
        public IActionResult FilterByRate(int avgRate)
        {
            //get products with price less than or equal to filtering price
            var FilteredProducts = context.Products.Where(p => p.productAverageRate == avgRate).ToList();
            return PartialView(FilteredProducts);
        }

        public IActionResult getProductDetails(int ProductId)
        {
           var product = context.Products.Find(ProductId);
           //ViewBag.color = ColorTranslator.FromHtml(product.productColor);

            return View(product);
        }
    }
}
