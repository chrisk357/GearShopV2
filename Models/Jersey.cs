﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GearShopV2.Models
{
    public class Jersey
    {
        public int Id { get; set; }
        [Required, Display(Name = "Brand")]
        public string JBrand { get; set; }
        [Required,  Display(Name = "Model")]
        public string JModel { get; set; }
        [Display(Name = "Color")]
        public string JColor { get; set; }
        [Required, Display(Name = "Size")]
        public string JSize { get; set; }
        [Required, Display(Name = "Price"), Column(TypeName = "decimal(18, 2)")]
        public double JPrice { get; set; }
        [Display(Name = "Sale Price"), Column(TypeName = "decimal(18, 2)")]
        public double JSalePrice { get; set; }
        [Required]
        public int JQtyOnHand { get; set; }
        [Display(Name = "Image")]
        public string JImageUrl { get; set; }
    }
}
