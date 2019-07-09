using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GearShopV2.Models
{
    public class GearColorViewModel
    {
        public List<Jersey> Jerseys { get; set; }
        public List<Pant> Pants { get; set; }
        public List<Helmet> Helmets { get; set; }
        public SelectList  Colors { get; set; }
        public string SearchString { get; set; }
    }
}
