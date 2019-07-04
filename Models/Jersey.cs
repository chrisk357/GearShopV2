using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GearShopV2.Models
{
    public class Jersey
    {
        public int Id { get; set; }
        public string JBrand { get; set; }
        public string JModel { get; set; }
        public string JColor { get; set; }
        public string JSize { get; set; }
        public double JPrice { get; set; }
        public double JSalePrice { get; set; }
        public int JQtyOnHand { get; set; }
    }
}
