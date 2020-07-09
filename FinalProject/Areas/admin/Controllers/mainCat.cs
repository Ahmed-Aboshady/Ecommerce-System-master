using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Areas.admin.Controllers
{
    [Area("admin")]
    public class mainCat : Controller
    {
        //Props
        private ApplicationDbContext db;
        private IWebHostEnvironment webhostenvironment;

        //Constructor
        public mainCat(ApplicationDbContext db , IWebHostEnvironment webhostenvironment)
        {
            this.db = db;
            this.webhostenvironment = webhostenvironment;
        }

        //ReadAction
        [HttpGet]
        public IActionResult Index()
        {
            List<mainCategory> allMainCat = db.MainCategories.ToList();
            return View(allMainCat);
        }

        //CreateActions
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(mainCategory newcategory , IFormFile mainCategoryPhoto)
        {
            if (ModelState.IsValid)
            { 
                if(mainCategoryPhoto != null)
                {
                    string wwwrootpath = webhostenvironment.WebRootPath;
                    string newMainCatPhoto = $"{Guid.NewGuid().ToString()}_{mainCategoryPhoto.FileName}";
                    string requiredPath = $"{wwwrootpath}/photos/{newMainCatPhoto}";
                    //mainCategoryPhoto.CopyTo(new FileStream(requiredPath , FileMode.Create));
                    using(var fileStream = new FileStream(requiredPath, FileMode.Create))
                    {
                        await mainCategoryPhoto.CopyToAsync(fileStream);
                    }

                    mainCategory NewCategory = new mainCategory() { mainCategoryName = newcategory.mainCategoryName , mainCategoryPhoto = newMainCatPhoto };
                    db.MainCategories.Add(NewCategory);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                else
                {
                    mainCategory NewCategory = new mainCategory() { mainCategoryName = newcategory.mainCategoryName};

                    db.MainCategories.Add(NewCategory);
                    db.SaveChanges();

                    return RedirectToAction("Index");

                }
            }
            else
            {
                return RedirectToAction("Create");
            }
        }


        //EditActions
        [HttpGet]
        public IActionResult Edit(int id)
        {
            mainCategory requiredRow = db.MainCategories.Find(id);
            return View(requiredRow);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int id , mainCategory modification, IFormFile mainCategoryPhoto)
        {
            if (ModelState.IsValid) 
            { 
                if(mainCategoryPhoto != null) 
                { 
                    string wwwrootpath = webhostenvironment.WebRootPath;
                    string newMainCatPhoto = $"{Guid.NewGuid().ToString()}_{mainCategoryPhoto.FileName}";
                    string path = $"{wwwrootpath}/photos/{newMainCatPhoto}";
                    using (var fileStream = new FileStream(path , FileMode.Create))
                    {
                        await mainCategoryPhoto.CopyToAsync(fileStream);
                    }

                    //mainCategoryPhoto.CopyTo(new FileStream(path, FileMode.Create));

                    mainCategory requiredRow = db.MainCategories.Find(id);

                    if(requiredRow.mainCategoryPhoto != null)
                    {
                        string oldMainCatPhoto = requiredRow.mainCategoryPhoto.ToString();
                        string oldPath = $"{wwwrootpath}/photos/{oldMainCatPhoto}";
                        if (System.IO.File.Exists(oldPath))
                        {
                            System.IO.File.Delete(oldPath);
                        }
                    }

                    requiredRow.mainCategoryName = modification.mainCategoryName;
                    requiredRow.mainCategoryPhoto = newMainCatPhoto;
                    db.SaveChanges();
            
                    return RedirectToAction("Index");
                }
                else
                {
                    mainCategory requiredRow = db.MainCategories.Find(id);
                    requiredRow.mainCategoryName = modification.mainCategoryName;
                    db.SaveChanges();

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
            mainCategory requiredRow = await db.MainCategories.FindAsync(id);

            if (requiredRow.mainCategoryPhoto != null)
            { 
                string wwwrootpath = webhostenvironment.WebRootPath;
                string oldMainCatPhoto = requiredRow.mainCategoryPhoto.ToString();
                string oldPath = $"{wwwrootpath}/photos/{oldMainCatPhoto}";
                if (System.IO.File.Exists(oldPath))
                {
                    System.IO.File.Delete(oldPath);
                }
            }

            db.MainCategories.Remove(requiredRow);
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
