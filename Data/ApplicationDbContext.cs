using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GearShopV2.Models;

namespace GearShopV2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GearShopV2.Models.Jersey> Jersey { get; set; }
        public DbSet<GearShopV2.Models.Pant> Pant { get; set; }
        public DbSet<GearShopV2.Models.Helmet> Helmet { get; set; }
        public DbSet<GearShopV2.Models.ContactUs> ContactUs { get; set; }
    }
}
