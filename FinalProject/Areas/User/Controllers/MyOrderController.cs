using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Areas.User.Controllers
{
    [Authorize]
    [Area("User")]
    public class MyOrderController : Controller
    {
        private ApplicationDbContext context;
        private UserManager<ApplicationUser> userManager;
        private SignInManager<ApplicationUser> signInManager;
        public MyOrderController(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager )
        {
            this.context = context;
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        public IActionResult Orders()
        {
            var UserId = userManager.GetUserId(User);
            var orders = context.orders.Where(o => o.userId == UserId).Include(o=>o.orderItems).ToList();
            return View(orders);
        }


        public IActionResult GetOrderItems(int orderId)
        {
            var orderItems = context.orderItems.Where(o => o.orderId == orderId).ToList();
            return View(orderItems);
        }
    }
}
