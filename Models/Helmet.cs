using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GearShopV2.Models
{
    public class Helmet
    {
        public int Id { get; set; }
        [Required, Display(Name = "Brand")]
        public string HBrand { get; set; }

        [Required, Display(Name = "Model")]
        public string HModel { get; set; }
        [Display(Name = "Color")]
        public string HColor { get; set; }
        [Required, Display(Name = "Size")]
        public string HSize { get; set; }
        [Required, Display(Name = "Price")]
        public double HPrice { get; set; }
        [Display(Name = "Sale Price")]
        public double HSalePrice { get; set; }
        [Required]
        public int HQtyOnHand { get; set; }
        [Display(Name = "Image")]
        public string HImageUrl { get; set; }

    }
}
