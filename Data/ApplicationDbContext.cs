using GearShopV2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GearShopV2.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
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
