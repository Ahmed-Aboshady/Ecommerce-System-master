using FinalProject.Areas.Identity.Pages.Account;
using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
    public class HomeViewModel
    {
        public List<product> products { get; set; }
        public List<mainCategory> mainCategories{ get; set; }
        public List<subCategory> subCategories { get; set; }


    }
}
