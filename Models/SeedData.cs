﻿using GearShopV2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

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

                //comments TODO NEED DATES 
                if(context.ContactUs.Any())
                {
                    return; 
                }
                context.ContactUs.AddRange(
                    new ContactUs
                    {
                        Posted = DateTime.Parse("8/2/2019"),
                        ContactName = "Jeffrey Smith",
                        ContactEmail = "Jsmith382@ymail.com",
                        ContactMessage = "Finally used your site and have to say I really enjoyed experience very cool " +
                        "and neat bud keep it up braaap!",
                    },                    
                    new ContactUs
                    {
                        Posted = DateTime.Parse("8/2/2019"),
                        ContactName = "Sam Hunt",
                        ContactEmail = "Shuntayy@ymail.com",
                        ContactMessage = "It is a long established fact that a reader will be distracted by the readable " +
                        "content of a page when looking at its layout. The point of using is that it has a more-or-less" +
                        "normal distribution of letters, as opposed to 'Content here, content here', making it look like readable English.",
                    },                    
                    new ContactUs
                    {
                        Posted = DateTime.Parse("8/3/2019"),
                        ContactName = "Josh Grant",
                        ContactEmail = "JDaddy33@gmail.com",
                        ContactMessage = "It is a long established fact that a reader will be distracted by the readable " +
                        "content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less" +
                        "normal distribution of letters, as opposed to using 'Content here,  look like readable English.",
                    },                    
                    new ContactUs
                    {
                        Posted = DateTime.Parse("8/6/2019"),
                        ContactName = "Grant Langston",
                        ContactEmail = "Zulluwarrior@gmail.com",
                        ContactMessage = "It is a long a reader will be distracted by the readable " +
                        "content of a page when looking at its layout. The point of using Lorem that it has a more-or-less" +
                        "normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                    },                    
                    new ContactUs
                    {
                        Posted = DateTime.Parse("8/8/2019"),
                        ContactName = "Ryan Dungey",
                        ContactEmail = "Dungey5@rocketmail.com",
                        ContactMessage = "It is a long established fact that a reader will be distracted by the readable " +
                        "content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less" +
                        "normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                    },                    
                    new ContactUs
                    {
                        Posted = DateTime.Parse("8/10/2019"),
                        ContactName = "Marvin Musquin",
                        ContactEmail = "Muskymusq@rocketmail.com",
                        ContactMessage = "It is a long established fact that a reader will be distracted by the readable " +
                        "content of its layout. The point of using Lorem Ipsum is that it has a more-or-less" +
                        "normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                    },                    
                    new ContactUs
                    {
                        Posted = DateTime.Parse("8/12/2019"),
                        ContactName = "Jeremy Mcgrath",
                        ContactEmail = "Showtime1@gmail.com",
                        ContactMessage = "It is a long established fact that a reader will be distracted by the readable " +
                        "content of a page when looking at its layout. The point of using Lorem Ipsum is that " +
                        "normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                    },                   
                    new ContactUs
                    {
                        Posted = DateTime.Parse("8/16/2019"),
                        ContactName = "Trey Canard",
                        ContactEmail = "Treybay41@gmail.com",
                        ContactMessage = "It is a long established fact that a reader will be distracted by the readable " +
                        "content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less" +
                        "normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                    },                    
                    new ContactUs
                    {
                        Posted = DateTime.Parse("8/18/2019"),
                        ContactName = "Ezra Lusk",
                        ContactEmail = "Yogilusk@gmail.com",
                        ContactMessage = "It is a long established fact that a reader will be distracted by the readable " +
                        "content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less" +
                        "normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                    },                     
                    new ContactUs
                    {
                        Posted = DateTime.Parse("8/20/2019"),
                        ContactName = "Jimmy Buffet",
                        ContactEmail = "JBuff@ymail.com",
                        ContactMessage = "It is a long established fact that a reader will be distracted by the readable " +
                        "content of a page when lookingis that it has a more-or-less" +
                        "normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                    },                         
                    new ContactUs
                    {
                        Posted = DateTime.Parse("8/20/2019"),
                        ContactName = "Joey Savatchy",
                        ContactEmail = "Nomorekawi@gmail.com",
                        ContactMessage = "It is a long established fact that a reader will be distracted by the readable " +
                        "content of a page when looking at I no longer have a ride im upset dangit please honda help its layout. The point of using Lorem Ipsum is that it has a more-or-less" +
                        "normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                    },                     
                    new ContactUs
                    {
                        Posted = DateTime.Parse("8/23/2019"),
                        ContactName = "Travis Pastranna",
                        ContactEmail = "NitroCircus@crazyymail.com",
                        ContactMessage = "It is a long established fact that a reader will be distracted by the readable " +
                        "content of a page when lookingis that it has a more-or-less" +
                        "normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                    },                    
                    new ContactUs
                    {
                        Posted = DateTime.Parse("8/25/2019"),
                        ContactName = "Kevin Windham",
                        ContactEmail = "Familyman14@ymail.com",
                        ContactMessage = "It is a long established fact that a reader will be distracted by the readable " +
                        "content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a less" +
                        "normal distribution of , as opposed to using ' here, content here', making it look like readable English.",
                    },                    
                    new ContactUs
                    {
                        Posted = DateTime.Parse("8/26/2019"),
                        ContactName = "Ricky Carmichael",
                        ContactEmail = "Rc4goat@ymail.com",
                        ContactMessage = "It is a long established fact will be distracted by the readable " +
                        "content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less" +
                        "normal distribution of letters, as opposed to using 'Content here, content here', making it look like English.",
                    });





                //look for jerseys
                if (context.Jersey.Any())
                {
                    return; //Db has been seeded
                }

                context.Jersey.AddRange(
                    new Jersey
                    {
                        JBrand = "MSR",
                        JModel = "NXT 2019",
                        JColor = "Blue/Red",
                        JSize = "L",
                        JPrice = 14.99,
                        JSalePrice = 14.99,
                        JQtyOnHand = 14,
                        JQtySold = 6,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/m/msr_19_jer_nxt-blu_red.jpg",
                        SizeCat = "Youth",
                    },                    
                    new Jersey
                    {
                        JBrand = "Klim",
                        JModel = "XC Lite",
                        JColor = "Red/Blue",
                        JSize = "XL",
                        JPrice = 39.99,
                        JSalePrice = 39.99,
                        JQtyOnHand = 14,
                        JQtySold = 6,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/k/kli_19_jer_xc_lit-red_blu.jpg",
                        SizeCat = "Youth",
                    },                    
                    new Jersey
                    {
                        JBrand = "Klim",
                        JModel = "XC Lite",
                        JColor = "Purple",
                        JSize = "XXL",
                        JPrice = 39.99,
                        JSalePrice = 39.99,
                        JQtyOnHand = 13,
                        JQtySold = 7,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/k/kli_19_jer_xc_lit-pur.jpg",
                        SizeCat = "Youth",
                    },                   
                    new Jersey
                    {
                        JBrand = "Fox",
                        JModel = "360 Murc",
                        JColor = "Green",
                        JSize = "XS",
                        JPrice = 59.95,
                        JSalePrice = 44.96,
                        JQtyOnHand = 7,
                        JQtySold = 13,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/f/fox_19_jer_360_mur-grn.jpg",
                        SizeCat = "Adult",
                    },                    
                    new Jersey
                    {
                        JBrand = "Fox",
                        JModel = "360 Murc",
                        JColor = "Blue Steel",
                        JSize = "S",
                        JPrice = 59.95,
                        JSalePrice = 44.96,
                        JQtyOnHand = 5,
                        JQtySold = 15,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/f/fox_19_jer_360_mur-blu_ste.jpg",
                        SizeCat = "Adult",
                    },
                    new Jersey
                    {
                        JBrand = "MSR",
                        JModel = "NXT 2019",
                        JColor = "Red/Black",
                        JSize = "S",
                        JPrice = 14.99,
                        JSalePrice = 14.99,
                        JQtyOnHand = 10,
                        JQtySold = 10,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/m/msr_19_jer_nxt-red_blk.jpg",
                        SizeCat = "Adult",
                    },
                    new Jersey
                    {
                        JBrand = "MSR",
                        JModel = "Axxis 19.5",
                        JColor = "Blue/Yellow",
                        JSize = "XS",
                        JPrice = 17.95,
                        JSalePrice = 17.95,
                        JQtyOnHand = 7,
                        JQtySold = 13,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/m/msr_19_jer_axx_19_5-blu_yel.jpg",
                        SizeCat = "Adult",
                    },
                    new Jersey
                    {
                        JBrand = "MSR",
                        JModel = "Axxis 19.5",
                        JColor = "Black/Flo Green",
                        JSize = "XS",
                        JPrice = 17.95,
                        JSalePrice = 17.95,
                        JQtyOnHand = 17,
                        JQtySold = 3,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/m/msr_19_jer_axx_19_5-blk_flo_grn.jpg",
                        SizeCat = "Adult",
                    },
                    new Jersey
                    {
                        JBrand = "Moose",
                        JModel = "Qualifier",
                        JColor = "Red/White/Blue",
                        JSize = "M",
                        JPrice = 25.95,
                        JSalePrice = 22.95,
                        JQtyOnHand = 9,
                        JQtySold = 11,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/m/moo_19_jer_qua-red_wht_blu.jpg",
                        SizeCat = "Youth",
                    },
                    new Jersey
                    {
                        JBrand = "Answer",
                        JModel = "Syncron Drift",
                        JColor = "Hyper Acid/Black",
                        JSize = "L",
                        JPrice = 25.95,
                        JSalePrice = 16.99,
                        JQtyOnHand = 11,
                        JQtySold = 9,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/a/ans_19_jer_syn_dri-hyp_aci_blk.jpg",
                        SizeCat = "Youth",
                    },
                    new Jersey
                    {
                        JBrand = "Shift",
                        JModel = "Whit3 Muse",
                        JColor = "Blue",
                        JSize = "S",
                        JPrice = 22.46,
                        JSalePrice = 22.46,
                        JQtyOnHand = 8,
                        JQtySold = 12,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/s/shi_19_jer_whi_mus-blu.jpg",
                        SizeCat = "Youth",
                    },
                    new Jersey
                    {
                        JBrand = "O'Neal",
                        JModel = "Element Afterburner",
                        JColor = "Blue/Red",
                        JSize = "S",
                        JPrice = 24.99,
                        JSalePrice = 18.74,
                        JQtyOnHand = 13,
                        JQtySold = 7,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/o/one_16_jer_ele_aft-blu_red.jpg",
                        SizeCat = "Adult",
                    },
                    new Jersey
                    {
                        JBrand = "Fox",
                        JModel = "180 Cota",
                        JColor = "Blue",
                        JSize = "S",
                        JPrice = 34.95,
                        JSalePrice = 26.21,
                        JQtyOnHand = 9,
                        JQtySold = 11,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/f/fox_19_jer_180_cot-blu.jpg",
                        SizeCat = "Adult",
                    },
                    new Jersey
                    {
                        JBrand = "Fox",
                        JModel = "180 Cota",
                        JColor = "Navy",
                        JSize = "M",
                        JPrice = 34.95,
                        JSalePrice = 26.21,
                        JQtyOnHand = 11,
                        JQtySold = 9,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/f/fox_19_jer_180_cot-nvy.jpg",
                        SizeCat = "Adult",
                    },
                    new Jersey
                    {
                        JBrand = "Answer",
                        JModel = "Syncron Flow",
                        JColor = "Astana/Indigo/Bright Red",
                        JSize = "XL",
                        JPrice = 25.95,
                        JSalePrice = 20.76,
                        JQtyOnHand = 6,
                        JQtySold = 14,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/a/ans_19_jer_syn_flo-ast_ind_bri_red.jpg",
                        SizeCat = "Adult",
                    },
                    new Jersey
                    {
                        JBrand = "Answer",
                        JModel = "Syncron Flow",
                        JColor = "Hyper Acid/Midnight/Astana",
                        JSize = "XL",
                        JPrice = 25.95,
                        JSalePrice = 20.76,
                        JQtyOnHand = 16,
                        JQtySold = 4,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/a/ans_19_jer_syn_flo-hyp_aci_mid_ast.jpg",
                        SizeCat = "Youth",
                    },
                    new Jersey
                    {
                        JBrand = "O'Neal",
                        JModel = "Element Afterburner",
                        JColor = "Blue/Red",
                        JSize = "M",
                        JPrice = 20.99,
                        JSalePrice = 20.99,
                        JQtyOnHand = 12,
                        JQtySold = 8,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/o/one_16_jer_ele_aft-blu_red.jpg",
                        SizeCat = "Youth",
                    },
                    new Jersey
                    {
                        JBrand = "Fox",
                        JModel = "180 Mastar",
                        JColor = "Black",
                        JSize = "XL",
                        JPrice = 34.95,
                        JSalePrice = 20.97,
                        JQtyOnHand = 10,
                        JQtySold = 10,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/f/fox_18_jer_180_mas-blk.jpg",
                        SizeCat = "Youth",
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
                        JQtySold = 7,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/f/fly_18_jer_evo_2-nvy_yel.jpg",
                        SizeCat = "Adult",
                    },                    
                    new Jersey
                    {
                        JBrand = "Fly",
                        JModel = "F-16",
                        JColor = "Neon Pink/Hi-Vis",
                        JSize = "XL",
                        JPrice = 27.95,
                        JSalePrice = 27.95,
                        JQtyOnHand = 7,
                        JQtySold = 13,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/f/fly_20_jer_f_16-neo_pnk_blk_hi_viz.jpg",
                        SizeCat = "Adult",
                    },                   
                    new Jersey
                    {
                        JBrand = "FastHouse",
                        JModel = "Hawk",
                        JColor = "Olive",
                        JSize = "XS",
                        JPrice = 59.99,
                        JSalePrice = 59.99,
                        JQtyOnHand = 17,
                        JQtySold = 3,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/f/fas_20_jer_haw-oli.jpg",
                        SizeCat = "Adult",
                    },                    
                    new Jersey
                    {
                        JBrand = "Thor",
                        JModel = "Pulse Jaws",
                        JColor = "Mint/Black",
                        JSize = "M",
                        JPrice = 34.95,
                        JSalePrice = 34.95,
                        JQtyOnHand = 10,
                        JQtySold = 10,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/t/tho_19_jer_pul_jaw-min_blk.jpg",
                        SizeCat = "Youth",
                    },                   
                    new Jersey
                    {
                        JBrand = "Fox",
                        JModel = "180 PRZM SE",
                        JColor = "Camo",
                        JSize = "XXL",
                        JPrice = 39.99,
                        JSalePrice = 39.99,
                        JQtyOnHand = 12,
                        JQtySold = 8,
                        JImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/f/fox_19_jer_180_przm_se-cam.jpg",
                        SizeCat = "Youth",
                    },
                    new Jersey
                    {
                        JBrand = "Fly",
                        JModel = "F-16 2019",
                        JColor = "Neon Pink/Black/Grey",
                        JSize = "XL",
                        JPrice = 21.99,
                        JSalePrice = 21.99,
                        JQtyOnHand = 8,
                        JQtySold = 12,
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
                        PModel = "NXT 2019",
                        PColor = "Blue/Red",
                        PSize = "38",
                        PPrice = 65.99,
                        PSalePrice = 65.99,
                        PQtyOnHand = 10,
                        PQtySold = 10,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/m/msr_19_pan_nxt-blu_red.jpg",
                        SizeCat = "Adult",
                    },
                    new Pant
                    {
                        PBrand = "Fly",
                        PModel = "F-16 2019",
                        PColor = "Blue/Black/Hi-Vis",
                        PSize = "33",
                        PPrice = 63.99,
                        PSalePrice = 63.99,
                        PQtyOnHand = 8,
                        PQtySold = 12,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/f/fly_19_pan_f16-blu_blk_hi_vis.jpg",
                        SizeCat = "Adult",
                    },                    
                    new Pant
                    {
                        PBrand = "Seven",
                        PModel = "Rival Trooper 2019",
                        PColor = "Paste",
                        PSize = "36",
                        PPrice = 129.99,
                        PSalePrice = 129.99,
                        PQtyOnHand = 8,
                        PQtySold = 12,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/s/sev_19_pan_riv_tro-pas.jpg",
                        SizeCat = "Adult",
                    },                    
                    new Pant
                    {
                        PBrand = "Fox",
                        PModel = "180",
                        PColor = "Blue",
                        PSize = "26",
                        PPrice = 109.95,
                        PSalePrice = 65.99,
                        PQtyOnHand = 10,
                        PQtySold = 12,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/f/fox_18_ldy_pan_180-blu.jpg",
                        SizeCat = "Youth",
                    },
                    new Pant
                    {
                        PBrand = "O'Neal",
                        PModel = "Racing Element 2019",
                        PColor = "Blue",
                        PSize = "28",
                        PPrice = 59.99,
                        PSalePrice = 59.99,
                        PQtyOnHand = 14,
                        PQtySold = 6,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/o/one_19_pan_ele-blu.jpg",
                        SizeCat = "Youth",
                    },
                    new Pant
                    {
                        PBrand = "Thor",
                        PModel = "Sector Shear",
                        PColor = "Light Grey/Red",
                        PSize = "30",
                        PPrice = 50.95,
                        PSalePrice = 50.95,
                        PQtyOnHand = 7,
                        PQtySold = 13,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/t/tho_19_pan_sec_she-lig_gry_red.jpg",
                        SizeCat = "Adult",
                    },
                    new Pant
                    {
                        PBrand = "Shift",
                        PModel = "Whit3 Muse",
                        PColor = "Purple",
                        PSize = "34",
                        PPrice = 79.99,
                        PSalePrice = 59.96,
                        PQtyOnHand = 19,
                        PQtySold = 1,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/s/shi_19_pan_whi_mus-pur.jpg",
                        SizeCat = "Adult",
                    },
                    new Pant
                    {
                        PBrand = "Answer",
                        PModel = "Syncron",
                        PColor = "Cyan/Navy",
                        PSize = "36",
                        PPrice = 54.99,
                        PSalePrice = 54.99,
                        PQtyOnHand = 9,
                        PQtySold = 11,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/a/ans_18_pan_syn-cya_nvy.jpg",
                        SizeCat = "Adult",
                    },
                    new Pant
                    {
                        PBrand = "Troy Lee",
                        PModel = "GP Jet",
                        PColor = "Yellow/Navy",
                        PSize = "26",
                        PPrice = 109.00,
                        PSalePrice = 87.20,
                        PQtyOnHand = 10,
                        PQtySold = 10,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/t/tld_19_pan_gp_jet-red_yel.jpg",
                        SizeCat = "Youth",
                    },
                    new Pant
                    {
                        PBrand = "Troy Lee",
                        PModel = "GP Jet",
                        PColor = "Blue",
                        PSize = "28",
                        PPrice = 109.00,
                        PSalePrice = 87.20,
                        PQtyOnHand = 13,
                        PQtySold = 7,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/t/tld_19_pan_gp_jet-blu.jpg",
                        SizeCat = "Youth",
                    },
                    new Pant
                    {
                        PBrand = "Moose",
                        PModel = "Qualifier",
                        PColor = "Teal/Hi-Viz",
                        PSize = "26",
                        PPrice = 67.95,
                        PSalePrice = 59.95,
                        PQtyOnHand = 12,
                        PQtySold = 8,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/m/moo_19_pan_qua-tea_hi_viz.jpg",
                        SizeCat = "Youth",
                    },
                    new Pant
                    {
                        PBrand = "Thor",
                        PModel = "Sector Shear",
                        PColor = "Sky/Slate",
                        PSize = "26",
                        PPrice = 64.95,
                        PSalePrice = 45.95,
                        PQtyOnHand = 14,
                        PQtySold = 6,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/t/tho_19_pan_sec_she-sky_sla.jpg",
                        SizeCat = "Youth",
                    },
                    new Pant
                    {
                        PBrand = "Fly",
                        PModel = "Kinetic Outlaw",
                        PColor = "Red/Blue",
                        PSize = "28",
                        PPrice = 114.95,
                        PSalePrice = 69.00,
                        PQtyOnHand = 12,
                        PQtySold = 8,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/f/fly_18_pan_kin_out_law-red_blu.jpg",
                        SizeCat = "Youth",
                    },
                    new Pant
                    {
                        PBrand = "Fly",
                        PModel = "Kinetic Outlaw",
                        PColor = "Black/Neon Pink/Hi-Vis",
                        PSize = "24",
                        PPrice = 114.95,
                        PSalePrice = 69.00,
                        PQtyOnHand = 7,
                        PQtySold = 13,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/f/fly_18_pan_kin_out_law-blk_neo_pnk_hi_viz.jpg",
                        SizeCat = "Youth",
                    },
                    new Pant
                    {
                        PBrand = "O'Neal",
                        PModel = "Element Afterburner",
                        PColor = "Blue/Red",
                        PSize = "34",
                        PPrice = 55.99,
                        PSalePrice = 79.99,
                        PQtyOnHand = 17,
                        PQtySold = 3,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/o/one_16_pan_ele_aft-blu_red.jpg",
                        SizeCat = "Adult",
                    },
                    new Pant
                    {
                        PBrand = "Answer",
                        PModel = "Alpha",
                        PColor = "White/Red/Black",
                        PSize = "36",
                        PPrice = 169.95,
                        PSalePrice = 79.99,
                        PQtyOnHand = 12,
                        PQtySold = 8,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/a/ans_16_pan_alp-whi_red_blk.jpg",
                        SizeCat = "Adult",
                    },
                    new Pant
                    {
                        PBrand = "Fly",
                        PModel = "Lite Hydrogen 2019",
                        PColor = "SeaFoam/Port/White",
                        PSize = "26",
                        PPrice = 127.46,
                        PSalePrice = 127.46,
                        PQtyOnHand = 9,
                        PQtySold = 11,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/f/fly_19_pan_lit_hyd-sea_por_whi.jpg",
                        SizeCat = "Adult",
                    },                    
                    new Pant
                    {
                        PBrand = "Moose",
                        PModel = "M1 2018",
                        PColor = "Hi-Viz/Magenta",
                        PSize = "34",
                        PPrice = 109.95,
                        PSalePrice = 84.95,
                        PQtyOnHand = 13,
                        PQtySold = 7,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/m/moo_18_pan_m1-hi_viz_mag.jpg",
                        SizeCat = "Adult",
                    },                    
                    new Pant
                    {
                        PBrand = "Moose",
                        PModel = "M1 2018",
                        PColor = "Green/Black",
                        PSize = "30",
                        PPrice = 109.95,
                        PSalePrice = 84.95,
                        PQtyOnHand = 7,
                        PQtySold = 13,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/m/moo_18_pan_m1-hi_viz_mag.jpg",
                        SizeCat = "Adult",
                    },                    
                    new Pant
                    {
                        PBrand = "Seven",
                        PModel = "Annex Exo",
                        PColor = "Black/Aqua",
                        PSize = "28",
                        PPrice = 98.00,
                        PSalePrice = 98.00,
                        PQtyOnHand = 7,
                        PQtySold = 13,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/s/sev_19_pan_ann_exo-blk_aqu.jpg",
                        SizeCat = "Adult",
                    },                   
                    new Pant
                    {
                        PBrand = "Seven",
                        PModel = "Annex Exo",
                        PColor = "Blue",
                        PSize = "38",
                        PPrice = 98.00,
                        PSalePrice = 98.00,
                        PQtyOnHand = 10,
                        PQtySold = 10,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/s/sev_19_pan_ann_exo-blu.jpg",
                        SizeCat = "Adult",
                    },                    
                    new Pant
                    {
                        PBrand = "Leatt",
                        PModel = "GPX 5.5 I.K.S",
                        PColor = "Black/Lime",
                        PSize = "26",
                        PPrice = 179.99,
                        PSalePrice = 143.99,
                        PQtyOnHand = 9,
                        PQtySold = 11,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/l/lea_19_pan_gpx_5_5_iks-blk_lim.jpg",
                        SizeCat = "Youth",
                    },                    
                    new Pant
                    {
                        PBrand = "Leatt",
                        PModel = "GPX 5.5 I.K.S",
                        PColor = "Ink/Blue",
                        PSize = "28",
                        PPrice = 179.99,
                        PSalePrice = 143.99,
                        PQtyOnHand = 9,
                        PQtySold = 11,
                        PImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/l/lea_19_pan_gpx_5_5_iks-blk_lim.jpg",
                        SizeCat = "Youth",
                    },
                    new Pant
                    {
                        PBrand = "Fly",
                        PModel = "Kinetic Era",
                        PColor = "Black/White",
                        PSize = "28",
                        PPrice = 79.99,
                        PSalePrice = 65.99,
                        PQtyOnHand = 6,
                        PQtySold = 14,
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
                    HQtySold = 10,
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
                    HQtySold = 13,
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
                    HQtySold = 11,
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
                    HQtySold = 4,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/f/fly_18_hel_tox_mips_res-blk_neo_pnk.jpg",
                    SizeCat = "Adult",
                },            
                new Helmet
                {
                    HBrand = "MSR",
                    HModel = "SC1 Grit",
                    HColor = "Matte Black/Flo Green",
                    HSize = "M",
                    HPrice = 109.99,
                    HSalePrice = 84.99,
                    HQtyOnHand = 21,
                    HQtySold = 0,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/m/msr_19_hel_sc1_gri-mat_blk_flo_grn.jpg",
                    SizeCat = "Adult",
                },                
                new Helmet
                {
                    HBrand = "Fly",
                    HModel = "Kinetic Burnish",
                    HColor = "Neon Pink/WHite",
                    HSize = "L",
                    HPrice = 109.95,
                    HSalePrice = 82.46,
                    HQtyOnHand = 11,
                    HQtySold = 9,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/f/fly_18_hel_kin_bur-neo_pnk_wht_pur.jpg",
                    SizeCat = "Adult",
                },                
                new Helmet
                {
                    HBrand = "Leatt",
                    HModel = "GPX 5.5 V15",
                    HColor = "White/Red",
                    HSize = "XXL",
                    HPrice = 259.99,
                    HSalePrice = 259.99,
                    HQtyOnHand = 9,
                    HQtySold = 11,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/l/lea_17_hel_gpx_5_5_v15-wht_red.jpg",
                    SizeCat = "Adult",
                },                 
                new Helmet
                {
                    HBrand = "O'Neal",
                    HModel = "3 Series Rancid",
                    HColor = "Multi",
                    HSize = "S",
                    HPrice = 119.99,
                    HSalePrice = 83.99,
                    HQtyOnHand = 13,
                    HQtySold = 7,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/o/one_18_hel_3_ser_ran-mul.jpg",
                    SizeCat = "Adult",
                },    
                new Helmet
                {
                    HBrand = "Shoei",
                    HModel = "VFX-EVO Glaive",
                    HColor = "Blue",
                    HSize = "M",
                    HPrice = 679.00,
                    HSalePrice = 543.29,
                    HQtyOnHand = 15,
                    HQtySold = 5,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/s/sho_18_hel_vfx_evo_gla-blu.jpg",
                    SizeCat = "Youth",
                },                
                new Helmet
                {
                    HBrand = "LS2",
                    HModel = "Subverter MX470",
                    HColor = "Bomber Hi-Vis Yellow",
                    HSize = "S",
                    HPrice = 219.98,
                    HSalePrice = 219.98,
                    HQtyOnHand = 6,
                    HQtySold = 14,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/l/ls2_18_hel_sub_mx_470-bom_hi_viz_yel.jpg",
                    SizeCat = "Youth",
                },                
                new Helmet
                {
                    HBrand = "LS2",
                    HModel = "Subverter MX470",
                    HColor = "Blade Laser Blue",
                    HSize = "M",
                    HPrice = 219.98,
                    HSalePrice = 219.98,
                    HQtyOnHand = 6,
                    HQtySold = 14,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/l/ls2_19_hel_sub_mx470-bla_las_blu_kro.jpg",
                    SizeCat = "Youth",
                },                
                new Helmet
                {
                    HBrand = "LS2",
                    HModel = "Fast V2 MX437",
                    HColor = "",
                    HSize = "XL",
                    HPrice = 139.98,
                    HSalePrice = 139.98,
                    HQtyOnHand = 12,
                    HQtySold = 8,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/l/ls2_18_hel_fas_mx_437-str_blu_red.jpg",
                    SizeCat = "Youth",
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
                    HQtySold = 8,
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
                    HQtySold = 15,
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
                    HQtySold = 7,
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
                    HQtySold = 7,
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
                    HQtySold = 12,
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
                    HQtySold = 8,
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
                    HQtySold = 12,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/t/tho_18_hel_sec_hyp-flo_aci_red.jpg",
                    SizeCat = "Youth",
                },
                new Helmet
                {
                    HBrand = "HJC",
                    HModel = "CS-MX 2 Dakota",
                    HColor = "Blue",
                    HSize = "XL",
                    HPrice = 89.99,
                    HSalePrice = 89.99,
                    HQtyOnHand = 14,
                    HQtySold = 6,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/h/hjc_18_hel_cs_mx2_dak-blu.jpg",
                    SizeCat = "Youth",
                },
                new Helmet
                {
                    HBrand = "HJC",
                    HModel = "CS-MX 2 Dakota",
                    HColor = "Blue",
                    HSize = "L",
                    HPrice = 89.99,
                    HSalePrice = 89.99,
                    HQtyOnHand = 14,
                    HQtySold = 6,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/h/hjc_18_hel_cs_mx2_dak-blu_wht_ora.jpg",
                    SizeCat = "Youth",
                },
                new Helmet
                {
                    HBrand = "Bell",
                    HModel = "Moto-9 Carbon Flex Monster Showtime",
                    HColor = "Green/Black",
                    HSize = "XS",
                    HPrice = 699.95,
                    HSalePrice = 349.99,
                    HQtyOnHand = 18,
                    HQtySold = 2,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/b/bel_18_hel_mot_9_car_fle_mon_sho_tim_rep-grn_blk.jpg",
                    SizeCat = "Adult",
                },
                new Helmet
                {
                    HBrand = "O'Neal",
                    HModel = "2 Series Slick 2019",
                    HColor = "White/Black",
                    HSize = "M",
                    HPrice = 76.99,
                    HSalePrice = 76.99,
                    HQtyOnHand = 11,
                    HQtySold = 9,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/o/one_19_hel_2_ser_sli-wht_blk.jpg",
                    SizeCat = "Adult",
                },
                new Helmet
                {
                    HBrand = "O'Neal",
                    HModel = "5 Series Wingman 2019",
                    HColor = "Multi/White",
                    HSize = "S",
                    HPrice = 97.99,
                    HSalePrice = 97.99,
                    HQtyOnHand = 6,
                    HQtySold = 14,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/o/one_18_hel_5_ser_win_man-mul_wht.jpg",
                    SizeCat = "Youth",
                },
                new Helmet
                {
                    HBrand = "Fox",
                    HModel = "V1 Motif",
                    HColor = "Red/White",
                    HSize = "L",
                    HPrice = 134.96,
                    HSalePrice = 179.95,
                    HQtyOnHand = 10,
                    HQtySold = 10,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/f/fox_19_hel_v1_mot-red_wht.jpg",
                    SizeCat = "Adult",
                },
                new Helmet
                {
                    HBrand = "Fox",
                    HModel = "V1 Motif",
                    HColor = "Blue/Grey",
                    HSize = "M",
                    HPrice = 134.96,
                    HSalePrice = 179.95,
                    HQtyOnHand = 10,
                    HQtySold = 10,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/f/fox_19_hel_v1_mot-blu_gry.jpg",
                    SizeCat = "Adult",
                },
                new Helmet
                {
                    HBrand = "Leatt",
                    HModel = "GPX 5.5 V10",
                    HColor = "Blue/White",
                    HSize = "XS",
                    HPrice = 259.99,
                    HSalePrice = 259.99,
                    HQtyOnHand = 14,
                    HQtySold = 6,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/l/lea_18_hel_gpx_5_5_v10-blu_wht.jpg",
                    SizeCat = "Adult",
                },
                new Helmet
                {
                    HBrand = "Leatt",
                    HModel = "GPX 5.5 V10",
                    HColor = "Lime/White",
                    HSize = "M",
                    HPrice = 259.99,
                    HSalePrice = 259.99,
                    HQtyOnHand = 14,
                    HQtySold = 6,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/l/lea_18_hel_gpx_5_5_v10-lim_wht.jpg",
                    SizeCat = "Adult",
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
                    HQtySold = 6,
                    HImageUrl = "https://images.rockymountainatvmc.com/images/prod/400/f/fox_18_hel_v1_rac-red.jpg",
                    SizeCat = "Youth",
                });

                context.SaveChanges();








            }
        }
    }
}
