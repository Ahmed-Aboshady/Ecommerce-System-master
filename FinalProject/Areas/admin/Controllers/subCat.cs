using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
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
    public class subCat : Controller
    {
        private ApplicationDbContext db;
        private IWebHostEnvironment webhostenviroment;
        public subCat(ApplicationDbContext db , IWebHostEnvironment webhostenviroment)
        {
            this.db = db;
            this.webhostenviroment = webhostenviroment;
        }

        //ReadAction
        public async Task<IActionResult> Index()
        {
            List<subCategory> allsubcategories = await db.SubCategories.ToListAsync();
            return View( allsubcategories);
        }


        //CreateActions
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            List<mainCategory> allmaincategories = await db.MainCategories.ToListAsync();
            SelectList maincategoriesforddl = new SelectList(allmaincategories, "mainCategoryId", "mainCategoryName");
            ViewBag.categories = maincategoriesforddl;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(subCategory newsubcategory , IFormFile subcategoryphoto)
        {
            if (ModelState.IsValid)
            { 
                if (subcategoryphoto != null)
                {
                    string wwwrootpath = webhostenviroment.WebRootPath;
                    string photoname = $"{Guid.NewGuid().ToString()}_{subcategoryphoto.FileName}";
                    string requiredpath = $"{wwwrootpath}/photos/{photoname}";
                    using (var fileStream = new FileStream(requiredpath , FileMode.Create))
                    {
                        await subcategoryphoto.CopyToAsync(fileStream);
                    }

                    subCategory newsubcategoryobject = new subCategory { subCategoryName = newsubcategory.subCategoryName, subCategoryPhoto = photoname , mainCategoryId = newsubcategory.mainCategoryId};
                    db.SubCategories.Add(newsubcategoryobject);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                else
                {
                    subCategory newsubcategoryobject = new subCategory { subCategoryName = newsubcategory.subCategoryName, MainCategory = newsubcategory.MainCategory };
                    db.SubCategories.Add(newsubcategoryobject);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
            }
            else
            {
                return RedirectToAction("Create");
            }

        }

        //UpdateActions
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            subCategory requiredrow = await db.SubCategories.FindAsync(id);
            List<mainCategory> maincategories = await db.MainCategories.ToListAsync();
            SelectList maincategoriesforddl = new SelectList(maincategories, "mainCategoryId", "mainCategoryName", requiredrow.mainCategoryId);
            ViewBag.categories = maincategoriesforddl;

            return View(requiredrow);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id , subCategory newsubcategory , IFormFile subcategoryphoto)
        {
            if (ModelState.IsValid)
            {
                if (subcategoryphoto != null)
                {
                    string wwwrootpath = webhostenviroment.WebRootPath;
                    string photoname = $"{Guid.NewGuid().ToString()}_{subcategoryphoto.FileName}";
                    string requiredpath = $"{wwwrootpath}/photos/{photoname}";
                    using (var fileStream = new FileStream(requiredpath, FileMode.Create))
                    {
                        await subcategoryphoto.CopyToAsync(fileStream);
                    }

                    subCategory requiredrow = await db.SubCategories.FindAsync(id);

                    if(requiredrow.subCategoryPhoto != null)
                    {
                        string oldphotoname = requiredrow.subCategoryPhoto.ToString();
                        string oldpath = $"{wwwrootpath}/photos/{oldphotoname}";
                        if (System.IO.File.Exists(oldpath))
                        {
                            System.IO.File.Delete(oldpath);
                        }
                    }

                    requiredrow.subCategoryName = newsubcategory.subCategoryName;
                    requiredrow.subCategoryPhoto = photoname;
                    requiredrow.mainCategoryId = newsubcategory.mainCategoryId;
                    await db.SaveChangesAsync();

                    return RedirectToAction("Index");
                }
                else
                {
                    subCategory requiredrow = await db.SubCategories.FindAsync(id);
                    requiredrow.subCategoryName = newsubcategory.subCategoryName;
                    requiredrow.mainCategoryId = newsubcategory.mainCategoryId;
                    await db.SaveChangesAsync();

                    return RedirectToAction("Index");
                }
            }
            else
            {
                return RedirectToAction("Edit");
            }
        }

        //DeleteAction
        public async Task<IActionResult> Delete(int id)
        {
            subCategory requiredrow = await db.SubCategories.FindAsync(id);
            string wwwrootpath = webhostenviroment.WebRootPath;

            if(requiredrow.subCategoryPhoto != null)
            {
                string oldphotoname = requiredrow.subCategoryPhoto.ToString();
                string oldpath = $"{wwwrootpath}/photos/{oldphotoname}";
                if (System.IO.File.Exists(oldpath))
                {
                    System.IO.File.Delete(oldpath);
                }
            }

            db.SubCategories.Remove(requiredrow);
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        //selectedCategoryProducts
    }
}
