using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GearShopV2.Models
{
    public class Pant
    {
        public int Id { get; set; }
        [Required, Display(Name = "Brand")]
        public string PBrand { get; set; }
        [Required, Display(Name = "Model")]
        public string PModel { get; set; }
        [Display(Name = "Color")]
        public string PColor { get; set; }
        [Required, Display(Name = "Size")]
        public string PSize { get; set; }
        [Required, Display(Name = "Price")]
        public double PPrice { get; set; }
        [Display(Name = "Sale Price")]
        public double PSalePrice { get; set; }
        [Required]
        public int PQtyOnHand { get; set; }
        [Display(Name = "Image")]
        public string PImageUrl { get; set; }
        [Display(Name = "Category")]
        public string SizeCat { get; set; }

    }
}
