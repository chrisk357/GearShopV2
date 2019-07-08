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
                    },                    
                    new Pant
                    {
                        PBrand = "O'Neal",
                        PModel = "Racing Element Pant 2019",
                        PColor = "Blue",
                        PSize = "28",
                        PPrice = 59.99,
                        PSalePrice = 59.99,
                        PQtyOnHand = 14,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/o/one_19_pan_ele-blu.jpg",
                    },                    
                    new Pant
                    {
                        PBrand = "Thor",
                        PModel = "Sector Shear Pant",
                        PColor = "Light Grey/Red",
                        PSize = "30",
                        PPrice = 50.95,
                        PSalePrice = 50.95,
                        PQtyOnHand = 7,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/t/tho_19_pan_sec_she-lig_gry_red.jpg",
                    },                    
                    new Pant
                    {
                        PBrand = "Fly",
                        PModel = "Kinetic Era Pants",
                        PColor = "Black/White",
                        PSize = "28",
                        PPrice = 79.99,
                        PSalePrice = 65.99,
                        PQtyOnHand = 6,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/f/fly_18_pan_kin_era-blk_wht.jpg",
                    });

                if (context.Helmet.Any())
                {
                    return; //Db has been seeded
                }
                context.Helmet.AddRange(
                new Helmet
                {
                    HBrand = "MSR",
                    HModel = "MAV4 W/MIPS",
                    HColor = "Red/Blue/White",
                    HSize = "S",
                    HPrice = 99.00,
                    HSalePrice = 99.00,
                    HQtyOnHand = 10,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/m/msr_19_hel_mav4-red_blu_wht.jpg",
                },
                new Helmet
                {
                    HBrand = "Bell",
                    HModel = "MX-9 W/MIPS",
                    HColor = "Tagger Asymmetric Blue/Pink",
                    HSize = "XS",
                    HPrice = 159.95,
                    HSalePrice = 135.96,
                    HQtyOnHand = 7,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/b/bell_19_hel_mx_9_mips-tag_asy_blu_pnk.jpg",
                },
                new Helmet
                {
                    HBrand = "Bell",
                    HModel = "MX-9 W/MIPS",
                    HColor = "Tagger Asymmetric Pink/Green",
                    HSize = "S",
                    HPrice = 159.95,
                    HSalePrice = 135.96,
                    HQtyOnHand = 9,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/b/bell_19_hel_mx_9_mips-tag_asy_blu_pnk.jpg",
                },
                new Helmet
                {
                    HBrand = "Fly",
                    HModel = "Toxin Resin W/MIPS",
                    HColor = "Black/Neon Pink",
                    HSize = "XL",
                    HPrice = 114.95,
                    HSalePrice = 114.95,
                    HQtyOnHand = 16,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/f/fly_18_hel_tox_mips_res-blk_neo_pnk.jpg",
                },
                new Helmet
                {
                    HBrand = "Fly",
                    HModel = "Toxin Resin W/MIPS",
                    HColor = "White/Yellow/Blue",
                    HSize = "M",
                    HPrice = 114.95,
                    HSalePrice = 114.95,
                    HQtyOnHand = 12,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/f/fly_18_hel_tox_mips_res-whi_yel_blu.jpg",
                },
                new Helmet
                {
                    HBrand = "Answer",
                    HModel = "AR5 W/MIPS",
                    HColor = "Acid/Blue",
                    HSize = "L",
                    HPrice = 299.95,
                    HSalePrice = 101.75,
                    HQtyOnHand = 5,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/a/ans_18_hel_ar5_mips-aci_blu.jpg",
                },
                new Helmet
                {
                    HBrand = "Fox",
                    HModel = "V1 Race Helmet",
                    HColor = "Red",
                    HSize = "S",
                    HPrice = 101.97,
                    HSalePrice = 101.97,
                    HQtyOnHand = 14,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/f/fox_18_hel_v1_rac-red.jpg",
                });

            context.SaveChanges();








            }
        }
    }
}
