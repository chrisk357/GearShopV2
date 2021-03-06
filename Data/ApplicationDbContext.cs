﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using GearShopV2.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace GearShopV2.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
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
