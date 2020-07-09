using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Areas.User.Controllers
{
    [Area("User")]
    public class HemalayaController : Controller
    {
        private ApplicationDbContext context;
        private UserManager<ApplicationUser> userManager;
        private SignInManager<ApplicationUser> signInManager;
      
        public HemalayaController(ApplicationDbContext context,
             UserManager<ApplicationUser> userManager,
             SignInManager<ApplicationUser> signInManager
             )
        {
            this.context = context;
            this.signInManager = signInManager;
            this.userManager = userManager;
        }
        
        public IActionResult Index()
        {

            var viewModel = new HomeViewModel()
            {
                products = context.Products.ToList(),
                mainCategories = context.MainCategories.ToList(),
                subCategories = context.SubCategories.ToList()
            };

            return View(viewModel);
        }

        //about
        public IActionResult About()
        {
            return View();
        }


        //contact us
        public IActionResult Contact()
        {
            return View();
        }
        //Add to cart
        [HttpPost]
        [Authorize]
        //[Route("Hemalaya")]
        public IActionResult Index(int ProductId)
        {
            //Get Id Of the currently logged in user
            var loggedInUser = userManager.GetUserId(User);
            bool idFound = false;
            List<penddingOrder> allpendding = context.penddingOrders.Select(x => x).ToList();
            foreach (var item in allpendding)
            {
                if (item.prod_id == ProductId)
                {
                    idFound = true;
                }
            }
            if (idFound != true)
            {
                penddingOrder pendding = new penddingOrder { prod_id = ProductId, user_id = loggedInUser };
                context.penddingOrders.Add(pendding);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [Route("Hemalaya/shoppingcart")]
        public IActionResult shoppingcart()
        {
            //Get Id Of the currently logged in user
            var loggedInUser = userManager.GetUserId(User);
            List<product> product = context.Products.Select(x => x).ToList();
            List<penddingOrder> penddings = context.penddingOrders.Select(x => x).ToList();
            List<int> ids = new List<int>();
            List<product> products = new List<product>();
            foreach (var item in penddings)
            {
                if (item.user_id == loggedInUser)
                {
                    ids.Add(item.prod_id);
                }
            }
            foreach (var item in ids)
            {
                foreach (var item1 in product)
                {
                    if (item == item1.productId)
                    {
                        product p = context.Products.Find(item);
                        products.Add(p);
                    }
                }
            }
            ViewBag.userId = loggedInUser;
            ViewBag.quntity = 1;
            return View(products);
            // return View("shopingCard");
        }

        public IActionResult makeOrder(string id, string address)
        {
            decimal totalPrice = 0;
            //make list of id's of his products and total price
            List<int> ids = new List<int>();
            List<penddingOrder> penddings = context.penddingOrders.Select(x => x).ToList();
            List<product> p = context.Products.Select(x => x).ToList();
            foreach (var item in penddings)
            {
                if (item.user_id == id)
                {
                    ids.Add(item.prod_id);
                    foreach (var item2 in p)
                    {
                        if (item.prod_id == item2.productId)
                        {
                            totalPrice += item2.productPrice;
                        }
                    }
                }
            }
            //make order with user id
            order newOrder = new order { userId = id, orederDate = DateTime.Now, orderAddress = address, orderTotalPrice = totalPrice, orderStatus = "Open" };
            context.orders.Add(newOrder);
            context.SaveChanges();
            //id of order just created
            int o_id = newOrder.orderId;
            //make order items for order
            foreach (var item in ids)
            {
                orderItem orderitem = new orderItem { orderId = o_id, productId = item, quantity = 1, subTotal = 1 * 2 };
                context.orderItems.Add(orderitem);
                context.SaveChanges();
            }
            //delete order from penndingOrder Because it aleady goes to order table
            foreach (var item in ids)
            {
                foreach (var item1 in penddings)
                {
                    if (item == item1.prod_id)
                    {
                        penddingOrder pend = context.penddingOrders.Find(item1.pendingId);
                        context.Remove(pend);
                        context.SaveChanges();
                    }
                }
            }

            return RedirectToAction("shoppingcart");
        }
        public IActionResult deleteFcart(int id)
        {
            penddingOrder pendding = context.penddingOrders.SingleOrDefault(x => x.prod_id == id);
            context.Remove(pendding);
            context.SaveChanges();
            return RedirectToAction("shoppingcart");
        }
    }
}
