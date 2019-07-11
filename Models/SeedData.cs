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
                        SizeCat = "Youth",
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
                        SizeCat = "Adult",
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
                        SizeCat = "Adult",
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
                        SizeCat = "Adult",
                    },                    
                    new Jersey
                    {
                        JBrand = "Moose",
                        JModel = "Qualifier Jersey",
                        JColor = "Red/White/Blue",
                        JSize = "M",
                        JPrice = 25.95,
                        JSalePrice = 22.95,
                        JQtyOnHand = 9,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/m/moo_19_jer_qua-red_wht_blu.jpg",
                        SizeCat = "Youth",
                    },                    
                    new Jersey
                    {
                        JBrand = "Answer",
                        JModel = "Syncron Drift Jersey",
                        JColor = "Hyper Acid/Black",
                        JSize = "L",
                        JPrice = 25.95,
                        JSalePrice = 16.99,
                        JQtyOnHand = 11,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/a/ans_19_jer_syn_dri-hyp_aci_blk.jpg",
                        SizeCat = "Youth",
                    },                    
                    new Jersey
                    {
                        JBrand = "Shift",
                        JModel = "Whit3 Muse Jersey",
                        JColor = "Blue",
                        JSize = "S",
                        JPrice = 22.46,
                        JSalePrice = 22.46,
                        JQtyOnHand = 8,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/s/shi_19_jer_whi_mus-blu.jpg",
                        SizeCat = "Youth",
                    },                    
                    new Jersey
                    {
                        JBrand = "O'Neal",
                        JModel = "Element Afterburner Jersey",
                        JColor = "Blue/Red",
                        JSize = "S",
                        JPrice = 24.99,
                        JSalePrice = 18.74,
                        JQtyOnHand = 13,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/o/one_16_jer_ele_aft-blu_red.jpg",
                        SizeCat = "Adult",
                    },                    
                    new Jersey
                    {
                        JBrand = "Fly",
                        JModel = "Evolution 2.0",
                        JColor = "Navy/Yellow",
                        JSize = "M",
                        JPrice = 30.99,
                        JSalePrice = 30.99,
                        JQtyOnHand = 13,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/f/fly_18_jer_evo_2-nvy_yel.jpg",
                        SizeCat = "Adult",
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
                        SizeCat = "Youth",
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
                        SizeCat = "Adult",
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
                        SizeCat = "Adult",
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
                        SizeCat = "Youth",
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
                        SizeCat = "Adult",
                    },                     
                    new Pant
                    {
                        PBrand = "Shift",
                        PModel = "Whit3 Muse Pant",
                        PColor = "Purple",
                        PSize = "34",
                        PPrice = 79.99,
                        PSalePrice = 59.96,
                        PQtyOnHand = 19,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/s/shi_19_pan_whi_mus-pur.jpg",
                        SizeCat = "Adult",
                    },                        
                    new Pant
                    {
                        PBrand = "Answer",
                        PModel = "Syncron Pant",
                        PColor = "Cyan/Navy",
                        PSize = "36",
                        PPrice = 54.99,
                        PSalePrice = 54.99,
                        PQtyOnHand = 9,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/a/ans_18_pan_syn-cya_nvy.jpg",
                        SizeCat = "Adult",
                    },                     
                    new Pant
                    {
                        PBrand = "Troy Lee",
                        PModel = "GP Jet Pant",
                        PColor = "Yellow/Navy",
                        PSize = "26",
                        PPrice = 109.00,
                        PSalePrice = 87.20,
                        PQtyOnHand = 10,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/t/tld_19_pan_gp_jet-red_yel.jpg",
                        SizeCat = "Youth",
                    },                     
                    new Pant
                    {
                        PBrand = "Troy Lee",
                        PModel = "GP Jet Pant",
                        PColor = "Blue",
                        PSize = "28",
                        PPrice = 109.00,
                        PSalePrice = 87.20,
                        PQtyOnHand = 13,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/t/tld_19_pan_gp_jet-blu.jpg",
                        SizeCat = "Youth",
                    },                        
                    new Pant
                    {
                        PBrand = "Moose",
                        PModel = "Qualifier Pant",
                        PColor = "Teal/Hi-Viz",
                        PSize = "26",
                        PPrice = 67.95,
                        PSalePrice = 59.95,
                        PQtyOnHand = 12,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/m/moo_19_pan_qua-tea_hi_viz.jpg",
                        SizeCat = "Youth",
                    },                    
                    new Pant
                    {
                        PBrand = "Fly",
                        PModel = "Kinetic Era Pant",
                        PColor = "Black/White",
                        PSize = "28",
                        PPrice = 79.99,
                        PSalePrice = 65.99,
                        PQtyOnHand = 6,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/f/fly_18_pan_kin_era-blk_wht.jpg",
                        SizeCat = "Youth",
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
                    SizeCat = "Youth",
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
                    SizeCat = "Adult",
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
                    SizeCat = "Youth",
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
                    SizeCat = "Adult",
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
                    SizeCat = "Youth",
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
                    SizeCat = "Adult",
                },                
                new Helmet
                {
                    HBrand = "Thor",
                    HModel = "Sector Hype",
                    HColor = "Grey/Pink",
                    HSize = "L",
                    HPrice = 83.95,
                    HSalePrice = 83.95,
                    HQtyOnHand = 13,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/t/tho_19_hel_sec_hyp-gry_pnk.jpg",
                    SizeCat = "Adult",
                },                
                new Helmet
                {
                    HBrand = "Answer",
                    HModel = "AR3 Haze",
                    HColor = "Grey/Blue",
                    HSize = "XL",
                    HPrice = 169.95,
                    HSalePrice = 57.85,
                    HQtyOnHand = 13,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/a/ans_18_hel_ar3_haz-gry_blu.jpg",
                    SizeCat = "Adult",
                },                
                new Helmet
                {
                    HBrand = "Troy Lee",
                    HModel = "SE4 Factory W/MIPS",
                    HColor = "Yellow/Blue",
                    HSize = "S",
                    HPrice = 200.00,
                    HSalePrice = 200.00,
                    HQtyOnHand = 8,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/t/tld_19_hel_se4_fac-yel_blu.jpg",
                    SizeCat = "Adult",
                },                
                new Helmet
                {
                    HBrand = "Fox",
                    HModel = "V1 Mata",
                    HColor = "Blue/White",
                    HSize = "S",
                    HPrice = 169.95,
                    HSalePrice = 127.46,
                    HQtyOnHand = 12,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/f/fox_19_hel_v1_mat-blu_wht.jpg",
                    SizeCat = "Youth",
                },                
                new Helmet
                {
                    HBrand = "Thor",
                    HModel = "Sector Hype",
                    HColor = "Flow Acid/Red",
                    HSize = "XS",
                    HPrice = 109.95,
                    HSalePrice = 83.95,
                    HQtyOnHand = 8,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/t/tho_18_hel_sec_hyp-flo_aci_red.jpg",
                    SizeCat = "Youth",
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
                    SizeCat = "Youth",
                });

            context.SaveChanges();








            }
        }
    }
}
