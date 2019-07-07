using GearShopV2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GearShopV2.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService
                    <DbContextOptions<ApplicationDbContext>>()))
            {
                //look for jerseys
                if (context.Jersey.Any())
                {
                    return; //Db has been seeded
                }
                context.Jersey.AddRange(
                    new Jersey
                    {
                        JBrand = "MSR",
                        JModel = "NXT Jersey 2019",
                        JColor = "Blue/Red",
                        JSize = "L",
                        JPrice = 14.99,
                        JSalePrice = 14.99,
                        JQtyOnHand = 14,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/m/msr_19_jer_nxt-blu_red.jpg",
                    },
                    new Jersey
                    {
                        JBrand = "MSR",
                        JModel = "NXT Jersey 2019",
                        JColor = "Red/Black",
                        JSize = "S",
                        JPrice = 14.99,
                        JSalePrice = 14.99,
                        JQtyOnHand = 10,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/m/msr_19_jer_nxt-red_blk.jpg",
                    },
                    new Jersey
                    {
                        JBrand = "MSR",
                        JModel = "Axxis Jersey 19.5",
                        JColor = "Blue/Yellow",
                        JSize = "XS",
                        JPrice = 17.95,
                        JSalePrice = 17.95,
                        JQtyOnHand = 7,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/m/msr_19_jer_axx_19_5-blu_yel.jpg",
                    },                    
                    new Jersey
                    {
                        JBrand = "MSR",
                        JModel = "Axxis Jersey 19.5",
                        JColor = "Black/Flo Green",
                        JSize = "XS",
                        JPrice = 17.95,
                        JSalePrice = 17.95,
                        JQtyOnHand = 17,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/m/msr_19_jer_axx_19_5-blk_flo_grn.jpg",
                    },
                    new Jersey
                    {
                        JBrand = "Fly",
                        JModel = "F-16 Jersey 2019",
                        JColor = "Neon Pink/Black/Grey",
                        JSize = "XL",
                        JPrice = 21.99,
                        JSalePrice = 21.99,
                        JQtyOnHand = 8,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/f/fly_19_jer_f16-neo_pnk_blk_gry.jpg",
                    });

                context.SaveChanges();


                if (context.Pant.Any())
                {
                    return; //Db has been seeded
                }
                context.Pant.AddRange(
                    new Pant
                    {
                        PBrand = "MSR",
                        PModel = "NXT Pant 2019",
                        PColor = "Blue/Red",
                        PSize = "38",
                        PPrice = 65.99,
                        PSalePrice = 65.99,
                        PQtyOnHand = 10,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/m/msr_19_pan_nxt-blu_red.jpg",
                    },                    
                    new Pant
                    {
                        PBrand = "Fly",
                        PModel = "F-16 Pant 2019",
                        PColor = "Blue/Black/Hi-Vis",
                        PSize = "33",
                        PPrice = 63.99,
                        PSalePrice = 63.99,
                        PQtyOnHand = 8,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/f/fly_19_pan_f16-blu_blk_hi_vis.jpg",
                    });
                context.SaveChanges();






            }
        }
    }
}
