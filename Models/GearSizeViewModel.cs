using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GearShopV2.Models
{
    public class GearSizeViewModel
    {
        public List<Jersey> Jerseys { get; set; }
        public List<Helmet> Helmets { get; set; }
        public List<Pant> Pants { get; set; }
        public SelectList SizeCats { get; set; }
        public string SizeCategory { get; set; }
        public string SearchString { get; set; }
    }
}
