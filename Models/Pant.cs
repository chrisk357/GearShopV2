using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GearShopV2.Models
{
    public class Pant
    {
        public int Id { get; set; }
        [Required]
        public string PBrand { get; set; }
        [Required]
        public string PModel { get; set; }
        public string PColor { get; set; }
        [Required]
        public string PSize { get; set; }
        [Required]
        public double PPrice { get; set; }
        public double PSalePrice { get; set; }
        [Required]
        public int PQtyOnHand { get; set; }
        public string PImageUrl { get; set; }

    }
}
