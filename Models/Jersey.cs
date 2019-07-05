using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GearShopV2.Models
{
    public class Jersey
    {
        public int Id { get; set; }
        [Required]
        public string JBrand { get; set; }
        [Required]
        public string JModel { get; set; }
        public string JColor { get; set; }
        [Required]
        public string JSize { get; set; }
        [Required]
        public double JPrice { get; set; }
        public double JSalePrice { get; set; }
        [Required]
        public int JQtyOnHand { get; set; }
        public string JImageUrl { get; set; }
    }
}
