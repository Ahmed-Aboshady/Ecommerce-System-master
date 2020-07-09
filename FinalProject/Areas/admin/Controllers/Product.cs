using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Areas.admin.Controllers
{
    [Area("admin")]
    public class Product : Controller
    {

        //Props
        private ApplicationDbContext db;
        private IWebHostEnvironment webHostEnvironment;


        //Constructor
        public Product(ApplicationDbContext db, IWebHostEnvironment webHostEnvironment)
        {
            this.db = db;
            this.webHostEnvironment = webHostEnvironment;
        }

        //ReadAction
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<product> allproducts = await db.Products.ToListAsync();

            return View(allproducts);
        }

        //ProductDetailsAction
        [HttpGet]
        public async Task<IActionResult> productDetails(int id)
        {
            product requiredrow = await db.Products.FindAsync(id);
            return View(requiredrow);
        }


        //CreateActions
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            List<subCategory> subCategories = await db.SubCategories.ToListAsync();
            SelectList selectListItems = new SelectList(subCategories, "subCategoryId", "subCategoryName");
            ViewBag.categories = selectListItems;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create( product newproduct , IFormFile productMainPhoto)
        {
            if (ModelState.IsValid)
            {
                if(productMainPhoto != null)
                {
                    string wwwrootpath = webHostEnvironment.WebRootPath;
                    string photoName = $"{Guid.NewGuid().ToString()}_{productMainPhoto.FileName}";
                    string photopath = $"{wwwrootpath}/photos/{photoName}";
                    using(var fileStream = new FileStream(photopath , FileMode.Create))
                    {
                        await productMainPhoto.CopyToAsync(fileStream);
                    }

                    product product = new product();
                    product.productName = newproduct.productName;
                    product.productQuantity = newproduct.productQuantity;
                    product.productDescription = newproduct.productDescription;
                    product.productColor = newproduct.productColor;
                    product.productPrice = newproduct.productPrice;
                    product.discountValue = newproduct.discountValue;
                    product.productPhoto = photoName;
                    product.brandName = newproduct.brandName;
                    product.productAddDate = DateTime.Now;
                    product.subCategoryId = newproduct.subCategoryId;

                    db.Products.Add(product);
                    await db.SaveChangesAsync();

                    int productId = product.productId;

                    return RedirectToAction("productsubphotos" , new { id = productId });
                }
                else
                {
                    product product = new product();
                    product.productName = newproduct.productName;
                    product.productQuantity = newproduct.productQuantity;
                    product.productDescription = newproduct.productDescription;
                    product.productColor = newproduct.productColor;
                    product.productPrice = newproduct.productPrice;
                    product.discountValue = newproduct.discountValue;                   
                    product.brandName = newproduct.brandName;
                    product.productAddDate = DateTime.Now;
                    product.subCategoryId = newproduct.subCategoryId;

                    db.Products.Add(product);
                    await db.SaveChangesAsync();

                    int productId = product.productId;

                    return RedirectToAction("productsubphotos" , new { id = productId });
                }
            }
            else
            {
                return RedirectToAction("Create");
            }
        }

        //ProductSubPhotosAction
        [HttpGet]
        public  IActionResult productsubphotos()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> productsubphotos(int id , IFormFile productSubPhotos)
        {
            if (ModelState.IsValid)
            {
                if (productSubPhotos != null)
                {
                    string wwwrootpath = webHostEnvironment.WebRootPath;
                    string photoName = $"{Guid.NewGuid().ToString()}_{productSubPhotos.FileName}";
                    string photopath = $"{wwwrootpath}/photos/{photoName}";
                    using (var fileStream = new FileStream(photopath, FileMode.Create))
                    {
                        await productSubPhotos.CopyToAsync(fileStream);
                    }

                    productSubPhoto productSubPhoto = new productSubPhoto();
                    productSubPhoto.photoName = photoName;
                    productSubPhoto.productId = id; 
                    db.ProductSubPhotos.Add(productSubPhoto);
                    await db.SaveChangesAsync();

                    return View();
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }


        //UpdateActions
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            product requiredrow = await db.Products.FindAsync(id);
            List<subCategory> subCategories = await db.SubCategories.ToListAsync();
            SelectList selectListItems = new SelectList(subCategories, "subCategoryId", "subCategoryName", requiredrow.subCategoryId);
            ViewBag.categories = selectListItems;

            return View(requiredrow);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id , product newproduct, IFormFile productMainPhoto)
        {
            if (ModelState.IsValid)
            {
                if (productMainPhoto != null)
                {
                    product requiredrow = await db.Products.FindAsync(id);

                    string wwwrootpath = webHostEnvironment.WebRootPath;
                    string photoName = $"{Guid.NewGuid().ToString()}_{productMainPhoto.FileName}";
                    string photopath = $"{wwwrootpath}/photos/{photoName}";
                    using (var fileStream = new FileStream(photopath, FileMode.Create))
                    {
                        await productMainPhoto.CopyToAsync(fileStream);
                    }

                    if(requiredrow.productPhoto != null)
                    {
                        string photoOldPath = $"{wwwrootpath}/photos/{requiredrow.productPhoto}";
                        if (System.IO.File.Exists(photoOldPath))
                        {
                            System.IO.File.Delete(photoOldPath);
                        }
                    }

                    requiredrow.productName = newproduct.productName;
                    requiredrow.productQuantity = newproduct.productQuantity;
                    requiredrow.productDescription = newproduct.productDescription;
                    requiredrow.productColor = newproduct.productColor;
                    requiredrow.productPrice = newproduct.productPrice;
                    requiredrow.discountValue = newproduct.discountValue;
                    requiredrow.productPhoto = photoName;
                    requiredrow.brandName = newproduct.brandName;        
                    requiredrow.subCategoryId = newproduct.subCategoryId;
                    
                    await db.SaveChangesAsync();

                    return RedirectToAction("productsubphotos" , new { id = id});
                }
                else
                {
                    product requiredrow = await db.Products.FindAsync(id);

                    requiredrow.productName = newproduct.productName;
                    requiredrow.productQuantity = newproduct.productQuantity;
                    requiredrow.productDescription = newproduct.productDescription;
                    requiredrow.productColor = newproduct.productColor;
                    requiredrow.productPrice = newproduct.productPrice;
                    requiredrow.discountValue = newproduct.discountValue;            
                    requiredrow.brandName = newproduct.brandName;
                    requiredrow.subCategoryId = newproduct.subCategoryId;

                    await db.SaveChangesAsync();

                    return RedirectToAction("productsubphotos" , new { id = id });
                }
            }
            else
            {
                return RedirectToAction("Edit");
            }
        }

        //DeleteActions
        public async Task<IActionResult> Delete(int id)
        {
            product requiredrow = await db.Products.FindAsync(id);

            if(requiredrow.productPhoto != null)
            {
                string wwwrootpath = webHostEnvironment.WebRootPath;
                string photoOldPath = $"{wwwrootpath}/photos/{requiredrow.productPhoto}";
                if (System.IO.File.Exists(photoOldPath))
                {
                    System.IO.File.Delete(photoOldPath);
                }
            }

            db.Products.Remove(requiredrow);
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        //DeleteSubPhoto
        [HttpGet]
        public async Task<IActionResult> DeleteSubPhoto(string name , int id)
        {
            productSubPhoto requiredrow = await db.ProductSubPhotos.Where(records => records.photoName == name).SingleOrDefaultAsync();

            if (requiredrow.photoName != null)
            {
                string wwwrootpath = webHostEnvironment.WebRootPath;
                string photoOldPath = $"{wwwrootpath}/photos/{requiredrow.photoName}";
                if (System.IO.File.Exists(photoOldPath))
                {
                    System.IO.File.Delete(photoOldPath);
                }
            }

            db.ProductSubPhotos.Remove(requiredrow);
            await db.SaveChangesAsync();

            return RedirectToAction("productDetails" , new { id = id });
        }
























    }
}
