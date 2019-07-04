using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GearShopV2.Models
{
    public class Pant
    {
        public int Id { get; set; }
        public string PBrand { get; set; }
        public string PModel { get; set; }
        public string PColor { get; set; }
        public string PSize { get; set; }
        public double PPrice { get; set; }
        public double PSalePrice { get; set; }
        public int PQtyOnHand { get; set; }
    }
}
