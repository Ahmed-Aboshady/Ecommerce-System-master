using System;
using System.Collections.Generic;
using System.Text;
using FinalProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<mainCategory> MainCategories { get; set; }
        public DbSet<subCategory> SubCategories { get; set; }
        public DbSet<product> Products { get; set; }
        public DbSet<productSubPhoto> ProductSubPhotos { get; set; }
        public DbSet<order> orders { get; set; }
        public DbSet<orderItem> orderItems { get; set; }
        public DbSet<rate> rates { get; set; }
        public DbSet<penddingOrder> penddingOrders { get; set; }

    }
}
