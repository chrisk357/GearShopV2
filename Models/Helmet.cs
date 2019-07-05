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
        [Required]
        public string HBrand { get; set; }

        [Required]
        public string HModel { get; set; }
        public string HColor { get; set; }
        [Required]
        public string HSize { get; set; }
        [Required]
        public double HPrice { get; set; }
        public double HSalePrice { get; set; }
        [Required]
        public int HQtyOnHand { get; set; }
        public string HImageUrl { get; set; }

    }
}
